using Google.Cloud.Firestore;

namespace DataAccess
{
    public class Access
    {
        private string BancoReferente;
        public Access(string bancoReferente)
        {
            this.BancoReferente = bancoReferente;
        }

        public  FirestoreDb AcessoBase()
        {
            string filepath = "../DataAccess/Access/genesis-93f18-firebase-adminsdk-j2gxw-f50f8eb355.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            return FirestoreDb.Create(this.BancoReferente);

        }


    }
}