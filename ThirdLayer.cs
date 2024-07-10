using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Numerics;

namespace Pharma__link
{
    internal class ThirdLayer
    {
        SqlConnection con;
        string str = "Data Source=DESKTOP-28AK21K; Initial Catalog=PharmaLink; Integrated Security=true; Trusted_Connection=true;encrypt=false;";

        public DataSet getMeds()
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("uspGetAllMeds", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Meds");
                    return ds;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataSet getClients()
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("uspGetclient", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Client");
                    return ds;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public string getUserName()
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspGetAdmin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", "ruth_74");
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        return dr["doctor_username"].ToString();
                    }
                    else { return ""; }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void Addmeds(Medication m)
        {

            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspInsertMeds", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@medname", m.MedName);
                    cmd.Parameters.AddWithValue("@company", m.Manufacturing_Company);
                    cmd.Parameters.AddWithValue("@dosage", m.Dosage);
                    cmd.Parameters.AddWithValue("@description", m.Description);
                    cmd.Parameters.AddWithValue("@pers", m.Perscription);
                    cmd.Parameters.AddWithValue("@date", m.Expiry_Date);
                    cmd.Parameters.AddWithValue("@amount", m.Amount);
                    cmd.Parameters.AddWithValue("@cost", m.Cost);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Med added succesfully.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Couldn't perform the task please try again", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void SaleMeds(Client c, Medication m)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                   
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspSaleMeds", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@medname", m.MedName);
                    cmd.Parameters.AddWithValue("@dosage", m.Dosage);
                    cmd.Parameters.AddWithValue("@amount", m.Amount);


                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        m.Cost = double.Parse(dr["cost"].ToString());
                        MessageBox.Show("Sale Successfull");

                    }
                    else
                    {
                        MessageBox.Show("Sale fail");

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataSet getMedsClients()
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("uspGetMedsClient", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Patient and meds");
                    return ds;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void AddClient(Client c, Medication m)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspAddClient", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", c.Patient_Name);
                    cmd.Parameters.AddWithValue("@Age", c.Patient_Age);
                    cmd.Parameters.AddWithValue("@medicine", m.MedName);
                    cmd.Parameters.AddWithValue("@meddosage", m.Dosage);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Client Saved succesfully.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteClient(Client c)
        {
            try
            {
                using (con = new SqlConnection(str))
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspDeleteClient", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", c.patientID);
                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Client Removed succesfully.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateClient(Client c, Medication m)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspUpdateClient", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", c.patientID);
                    cmd.Parameters.AddWithValue("@name", c.Patient_Name);
                    cmd.Parameters.AddWithValue("@Age", c.Patient_Age);
                    cmd.Parameters.AddWithValue("@medicine", m.MedName);
                    cmd.Parameters.AddWithValue("@meddosage", m.Dosage);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Client Updated succesfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SignUp(Doctor d)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspSignup", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", d.Doctor_Name);
                    cmd.Parameters.AddWithValue("@username", d.Doctor_Username);
                    cmd.Parameters.AddWithValue("@password", d.Doctor_Password);
                    cmd.Parameters.AddWithValue("@spec", d.Specialization);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Signed Up succesfully. Now try And Login", "Signed Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Boolean login(Doctor d)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspLogin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", d.Doctor_Username);
                    cmd.Parameters.AddWithValue("@password", d.Doctor_Password);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        d.Doctor_Name = dr["Doctor_Name"].ToString();
                        d.Specialization = dr["Specialization"].ToString();
                        return true;
                    }
                     return false; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void CheckPerscription(Client c, Medication m)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspCheckPrescription", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@medname", m.MedName);
                    cmd.Parameters.AddWithValue("@dosage", m.Dosage);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        m.Perscription = dr["Prescription"].ToString();
                        m.Perscription=m.Perscription.ToLower();
                        string PID = dr["patientID"].ToString();
                        string MNAME = dr["Medication_Name"].ToString();
                        
                        if(m.Perscription != "true")
                        {
                            SaleMeds(c, m);
                        }
                        else if (m.Perscription=="true" && PID == c.patientID.ToString() && MNAME == m.MedName)
                        {
                            SaleMeds(c, m);
                        }

                        else
                        {
                            MessageBox.Show("Couldn't allow Sale!!! Make sure to Add the Client to specific as it requires perscription Medication First.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No medication with that name");
           
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }
        }
    }
}
