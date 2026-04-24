using System;
using System.Data;
using System.Data.SqlClient;

namespace CafeOtomasyonu.DAL
{
    public static class DatabaseHelper
    {
        private static string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=CafeOtomasyonuDB;Trusted_Connection=True;";

        public static DataTable GetData(string query, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        con.Open();
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Veritabanından okuma yapılırken hata oluştu:\n{ex.Message}", "Hata", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return dt;
        }

        public static int ExecuteCommand(string query, params SqlParameter[] parameters)
        {
            int result = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        con.Open();
                        result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Veritabanına yazılırken hata oluştu:\n{ex.Message}", "Hata", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return result;
        }

        public static int ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            int result = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        con.Open();
                        object res = cmd.ExecuteScalar();
                        if(res != null && res != DBNull.Value)
                        {
                            result = Convert.ToInt32(res);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Veritabanına (Scalar) yazılırken hata oluştu:\n{ex.Message}", "Hata", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return result;
        }

        public static void TablolariGuncelle()
        {
            string sqlScript = @"
                IF EXISTS(SELECT 1 FROM sys.columns WHERE Name = N'KategoriId' AND Object_ID = Object_ID(N'Urunler'))
                BEGIN ALTER TABLE Urunler ALTER COLUMN KategoriId INT NULL; END

                IF COL_LENGTH('SatisDetaylari', 'Tutar') IS NULL BEGIN ALTER TABLE SatisDetaylari ADD Tutar DECIMAL(18,2) NOT NULL DEFAULT 0 END;
                IF COL_LENGTH('SatisDetaylari', 'Indirim') IS NULL BEGIN ALTER TABLE SatisDetaylari ADD Indirim DECIMAL(18,2) NOT NULL DEFAULT 0 END;
                IF COL_LENGTH('SatisDetaylari', 'Aciklama') IS NULL BEGIN ALTER TABLE SatisDetaylari ADD Aciklama NVARCHAR(500) NULL END;

                IF COL_LENGTH('Satislar', 'Tutar') IS NULL BEGIN ALTER TABLE Satislar ADD Tutar DECIMAL(18,2) NOT NULL DEFAULT 0 END;
                IF COL_LENGTH('Satislar', 'Indirim') IS NULL BEGIN ALTER TABLE Satislar ADD Indirim DECIMAL(18,2) NOT NULL DEFAULT 0 END;
                IF COL_LENGTH('Satislar', 'Odenen') IS NULL BEGIN ALTER TABLE Satislar ADD Odenen DECIMAL(18,2) NOT NULL DEFAULT 0 END;
                IF COL_LENGTH('Satislar', 'Kalan') IS NULL BEGIN ALTER TABLE Satislar ADD Kalan DECIMAL(18,2) NOT NULL DEFAULT 0 END;

                IF COL_LENGTH('Odemeler', 'OdemeTutari') IS NULL BEGIN ALTER TABLE Odemeler ADD OdemeTutari DECIMAL(18,2) NOT NULL DEFAULT 0 END;

                IF COL_LENGTH('Kullanicilar', 'Adres') IS NULL BEGIN ALTER TABLE Kullanicilar ADD Adres NVARCHAR(250) NULL END;
                IF COL_LENGTH('Kullanicilar', 'Email') IS NULL BEGIN ALTER TABLE Kullanicilar ADD Email NVARCHAR(100) NULL END;
                IF COL_LENGTH('Kullanicilar', 'Gorevi') IS NULL BEGIN ALTER TABLE Kullanicilar ADD Gorevi NVARCHAR(50) NULL END;
                IF COL_LENGTH('Kullanicilar', 'AktifMi') IS NULL BEGIN ALTER TABLE Kullanicilar ADD AktifMi BIT NOT NULL DEFAULT 1 END;
                IF COL_LENGTH('Kullanicilar', 'Soru') IS NULL BEGIN ALTER TABLE Kullanicilar ADD Soru NVARCHAR(100) NULL END;
                IF COL_LENGTH('Kullanicilar', 'Cevap') IS NULL BEGIN ALTER TABLE Kullanicilar ADD Cevap NVARCHAR(100) NULL END;
                IF COL_LENGTH('Kullanicilar', 'Aciklama') IS NULL BEGIN ALTER TABLE Kullanicilar ADD Aciklama NVARCHAR(500) NULL END;
            ";
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlScript, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
            }
        }
    }
}
