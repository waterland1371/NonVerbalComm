using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;


namespace NonVerbalComm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

       
        //only works with a gmail address currently
        private void emailButton_Click(object sender, EventArgs e)
        {

            Save();


        }
        private string _email = null;
        

        private void Save()
        {
            PopupWindow popup = new PopupWindow();
            popup.ShowDialog();
            string email = popup.EnteredText;
            popup.Dispose();
            string currentDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\settings.settings"; ;
            string path = currentDirectoryPath;
            string savedEmail = email;
            File.WriteAllText(path, savedEmail);
            this._email = savedEmail;
        }

        private void bathroomPic_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("nonverbalapp@gmail.com");
                mail.To.Add(_email);
                mail.Subject = "Non Verbal Communication, I need to use the bathroom!";
                mail.Body = "I need to use the bathroom!";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("nonverbalapp", "pittsBURg3");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                EmailSent sent = new EmailSent();
                sent.ShowDialog();

            }
            catch (Exception ex)
            {  
                MessageBox.Show(ex.ToString());
            }
        }

        private void QuestionPic_Click(object sender, EventArgs e)
        {

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("nonverbalapp@gmail.com");
                mail.To.Add(_email);
                mail.Subject = "Non Verbal Communication, I need Someone";
                mail.Body = "I need someone!";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("nonverbalapp", "pittsBURg3");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                EmailSent sent = new EmailSent();
                sent.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void alertPic_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("nonverbalapp@gmail.com");
                mail.To.Add(_email);
                mail.Subject = "HELP Non Verbal Communication, HELP";
                mail.Body = "I need help!";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("nonverbalapp", "pittsBURg3");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                EmailSent sent = new EmailSent();
                sent.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void foodPic_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("nonverbalapp@gmail.com");
                mail.To.Add(_email);
                mail.Subject = "Non Verbal Communication, I'm hungry";
                mail.Body = "I'm hungry!";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("nonverbalapp", "pittsBURg3");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                EmailSent sent = new EmailSent();
                sent.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void sleepPic_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("nonverbalapp@gmail.com");
                mail.To.Add(_email);
                mail.Subject = "Non Verbal Communication, I'm tired";
                mail.Body = "I'm tired!";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("nonverbalapp", "pittsBURg3");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                EmailSent sent = new EmailSent();
                sent.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void playPic_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("nonverbalapp@gmail.com");
                mail.To.Add(_email);
                mail.Subject = "Non Verbal Communication, I want to play";
                mail.Body = "I want to play!";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("nonverbalapp", "pittsBURg3");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                EmailSent sent = new EmailSent();
                sent.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
   
}
