using DAL;

namespace BLL
{
    public class GaleriBLL
    {
       // GaleriContext _context;
        public GaleriBLL()
        {
            //Tightly Coupling
            //İleride boyle kullmayacağız 
            //Neden ????
            //OCP'ye aykırı...
            //Loosely Coupling olmalı...
            //DIP(Dependency Inversion Principles)
            //IoC(Inversion Of Control)
            // _context = new GaleriContext();

            Arabalar = new ArabaManager();
            Modeller = new ModelManager();
            Markalar = new MarkaManager();
        }

        public ArabaManager Arabalar { get; set; }
        public MarkaManager Markalar { get; set; }
        public ModelManager Modeller { get; set; }



    }
}