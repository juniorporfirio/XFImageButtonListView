using System.Collections.ObjectModel;
using XFlImageButtonListView.Model;

namespace XFlImageButtonListView.ViewModel
{
    public class PalestranteVM
    {
        public ObservableCollection<Palestrante> Palestrantes
        {
            get;
            set;
        }

        public PalestranteVM()
        {
            ObservableCollection<Palestrante> listaPalestrante = new ObservableCollection<Palestrante>();

            listaPalestrante.Add(new Palestrante { Nome = "Nome1", Image = "callanswer.png" });

            listaPalestrante.Add(new Palestrante { Nome = "Nome2", Image ="callanswer.png" });

            Palestrantes = listaPalestrante;
            
        }
    }
}
