using LibraryManagement.Domain.Model;
using Npgsql;
using System.Data;

namespace LibraryManagementSystem.Domain.Repository
{
    public class  MemberRepository
    {
        private readonly DBConnection _db;
        
        public MemberRepository(DBConnection db)
        {
            _db = db;
        }

        public DataRow GetMemberById(int memberId)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM member WHERE memberid = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", memberId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                    }
                }
            }
        }

        public void AddMember(Member member)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();

                string query = @"
            INSERT INTO member 
            (name, email, phone, address, membershipdate)
            VALUES 
            (@name, @email, @phone, @address, @membershipDate)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", member.Name);
                    cmd.Parameters.AddWithValue("@email", member.Email);
                    cmd.Parameters.AddWithValue("@phone", member.Phone);
                    cmd.Parameters.AddWithValue("@address", member.Address);
                    cmd.Parameters.AddWithValue("@membershipDate", member.MembershipDate);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public DataTable GetAllMembers(string search = "")
        {
            DataTable dt = new DataTable();
            using (var conn = _db.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT memberid, name, email, phone, address, membershipdate
                    FROM member
                    WHERE 
                        is_deleted = 'FALSE'
                        AND
                        (@search = '' 
                        OR CAST(memberid AS TEXT) ILIKE @pattern
                        OR name ILIKE @pattern 
                        OR email ILIKE @pattern 
                        OR phone ILIKE @pattern) 
                    ORDER BY memberid ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", search);
                    cmd.Parameters.AddWithValue("@pattern", "%" + search + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public void EditMember(int memberId, string name, string email, string phone, string address)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE member SET name=@name, email=@email, phone=@phone, address=@address WHERE memberid=@id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@id", memberId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteMember(int memberId)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM member WHERE memberid = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", memberId);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
