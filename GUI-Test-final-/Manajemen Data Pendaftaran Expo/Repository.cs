using System;
using Npgsql;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Manajemen_Data_Pendaftaran_Expo
{
    internal class Repository
    {

        public Repository()
        {
            
        }

        public void SaveParticipantsToDatabase()
        {
            ParticipantRepository.ImportParticipantsToPostgres("Host=localhost;Port=5432;Username=postgres;Password=digitalk3y;Database=HoloParticipants");
        }
    }

    public static class ParticipantRepository
    {
        public static BindingList<Participants> ParticipantsList { get; } = new BindingList<Participants>();

        public static void ImportParticipantsToPostgres(string connectionString)
        {
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            foreach (var participant in ParticipantsList)
            {
                try
                {
                    using var cmd = new NpgsqlCommand(@"
                        INSERT INTO participants 
                            (tokens, firstname, lastname, address, phone, age, email, class_name, registered)
                        VALUES 
                            (@tokens, @firstname, @lastname, @address, @phone, @age, @email, @class_name, @registered)
                        ON CONFLICT (tokens) DO NOTHING;", conn);

                    cmd.Parameters.AddWithValue("tokens", participant.Token);
                    cmd.Parameters.AddWithValue("firstname", participant.FirstName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("lastname", participant.LastName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("address", participant.Address ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("phone", participant.Phone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("age", participant.Age ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("email", participant.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("class_name", participant.Class ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("registered", participant.Registered.ToDateTime(TimeOnly.MinValue));

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static List<Participants> GetParticipantsFromPostgres(string connectionString)
        {
            var participants = new List<Participants>();
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            using var cmd = new NpgsqlCommand("SELECT tokens, firstname, lastname, address, phone, age, email, class_name, registered FROM participants", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                participants.Add(new Participants
                {
                    Token = reader.GetInt32(0),
                    FirstName = reader.IsDBNull(1) ? null : reader.GetString(1),
                    LastName = reader.IsDBNull(2) ? null : reader.GetString(2),
                    Address = reader.IsDBNull(3) ? null : reader.GetString(3),
                    Phone = reader.IsDBNull(4) ? null : reader.GetString(4),
                    Age = reader.IsDBNull(5) ? null : reader.GetString(5),
                    Email = reader.IsDBNull(6) ? null : reader.GetString(6),
                    Class = reader.IsDBNull(7) ? null : reader.GetString(7),
                    Registered = reader.IsDBNull(8) ? default : DateOnly.FromDateTime(reader.GetDateTime(8))
                });
            }
            return participants;
        }

        public static void DeleteParticipantFromPostgres(int token, string connectionString)
        {
            using var conn = new Npgsql.NpgsqlConnection(connectionString);
            conn.Open();
            using var cmd = new Npgsql.NpgsqlCommand("DELETE FROM participants WHERE tokens = @tokens", conn);
            cmd.Parameters.AddWithValue("tokens", token);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected == 0)
            {
                MessageBox.Show($"No participant with token {token} was found.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}