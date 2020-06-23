namespace Aula23Listasdeobjetos
{
    public class Cartao
    {

        public string  Titular { get; set; }
        public int Numero { get; set; }
        public string Bandeira { get; set; }
        public int Vencimento { get; set; }
        public float cvv { get; set; }

        public Cartao(){

        }

        public Cartao(string _titular,int _numero,string _bandeira,int _vencimento, float _cvv){
            this.Titular = _titular;
            this.Numero = _numero;
            this.Bandeira = _bandeira;
            this.Vencimento = _vencimento;
            this.cvv = _cvv;
        }
    }
}