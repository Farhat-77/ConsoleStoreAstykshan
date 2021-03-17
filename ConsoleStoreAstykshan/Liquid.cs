namespace ConsoleStoreAstykshan
{
    public class Liquid
    {
        private string nameOfLiquid;
        private Magazin magazin;

        public Liquid(string nameOfLiquid, Magazin magazin)
        {
            this.nameOfLiquid = nameOfLiquid;
            this.magazin = magazin;
        }
    }
}