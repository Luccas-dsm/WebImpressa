using Impressa.Shared.Models;

namespace DataAccess.Mock
{
    public class MockData
    {
        public async Task<List<MockModel>> RetornaImagemC1()
        {
            return new List<MockModel>() {
                    new MockModel()
                    {
                        Imagem = "https://img.freepik.com/fotos-gratis/vista-do-tigre-na-natureza_23-2150460847.jpg?w=740&t=st=1687102310~exp=1687102910~hmac=c86aac84919c9451b01d7182a5da59a98d5688449695ef2e60cb37c603c40836",
                    },
                new MockModel()
                    {
                        Imagem ="https://img.freepik.com/fotos-gratis/linda-borboleta-na-natureza_23-2150445557.jpg?w=740&t=st=1687102340~exp=1687102940~hmac=e8a5a041fd5ce4b80cab11b12fdab835aaca8b2f82a4cd255d9c229542920b13"
                    },         new MockModel()
                    {
                        Imagem = "https://img.freepik.com/fotos-gratis/vista-do-tigre-na-natureza_23-2150460847.jpg?w=740&t=st=1687102310~exp=1687102910~hmac=c86aac84919c9451b01d7182a5da59a98d5688449695ef2e60cb37c603c40836",
                    },         new MockModel()
                    {
                        Imagem = "https://img.freepik.com/fotos-gratis/vista-do-tigre-na-natureza_23-2150460847.jpg?w=740&t=st=1687102310~exp=1687102910~hmac=c86aac84919c9451b01d7182a5da59a98d5688449695ef2e60cb37c603c40836",
                    }
            };
        }

    }
}
