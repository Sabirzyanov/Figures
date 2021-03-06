/* 
    Insaf Sabirzyanov 220P,
    Task "Figures 4"
    30.05.22
*/

using System.Runtime.Serialization.Formatters.Binary;

namespace Figures3
{
    
    public class Figures
    {
        List<Figure> figures;

        public Figures()
        {
            figures = new List<Figure>();
        }


        public void Add(Figure f)
        {
            figures.Add(f);
        }

        public void Save(string path)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = File.Open(path, FileMode.Create))
                {
                    binFormat.Serialize(fStream, figures);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            
        }

        public void Load(string path)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = File.Open(path, FileMode.Open))
                {
                    figures = (List<Figure>) binFormat.Deserialize(fStream);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public void Draw(IDrawer drawer)
        {
            foreach (Figure f in figures)
            {
                f.Draw(drawer);
            }
        }

        public int GetCount()
        {
            return figures.Count;
        }
    }
}
