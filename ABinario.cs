using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arbol
{
    public partial class ABinario : Form
    {
        int numerosGenerar = 15;
        ArbolBinario arbol = new ArbolBinario();
        TreeNode[] arbolNodos;
        Inicio start = new Inicio();
        public ABinario(Inicio ini)
        {
            InitializeComponent();
            start = ini;
        }

        private void ABinario_Load(object sender, EventArgs e)
        {
            arbol.Insertar(1);
            arbol.Insertar(2);
            arbol.Insertar(3);
            arbol.Insertar(4);
            arbol.Insertar(5);
            arbol.Insertar(6);
            arbol.Insertar(7);
            arbol.Insertar(8);
            arbol.Insertar(9);
            arbol.Insertar(10);
            arbol.Insertar(11);
            arbol.Insertar(12);
            arbol.Insertar(13);
            arbol.Insertar(14);
            arbol.Insertar(15);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Generar_Click(object sender, EventArgs e)
        {
            arbolNodos = new TreeNode[numerosGenerar];
            generarNodos();
            mostrarArbol.Nodes.Add(arbolNodos[0]);
        }
        private void generarNodos()
        {
            for (int a = 0; a < numerosGenerar; a++)
            {
                string auxiliar = Convert.ToString(a + 1);
                arbolNodos[a] = new TreeNode(auxiliar);
            }

            arbolNodos[0].Nodes.Add(arbolNodos[1]);
            arbolNodos[0].Nodes.Add(arbolNodos[2]);
            arbolNodos[1].Nodes.Add(arbolNodos[3]);
            arbolNodos[1].Nodes.Add(arbolNodos[4]);
            arbolNodos[2].Nodes.Add(arbolNodos[5]);
            arbolNodos[2].Nodes.Add(arbolNodos[6]);
            arbolNodos[3].Nodes.Add(arbolNodos[7]);
            arbolNodos[3].Nodes.Add(arbolNodos[8]);
            arbolNodos[4].Nodes.Add(arbolNodos[9]);
            arbolNodos[4].Nodes.Add(arbolNodos[10]);
            arbolNodos[5].Nodes.Add(arbolNodos[11]);
            arbolNodos[5].Nodes.Add(arbolNodos[12]);
            arbolNodos[6].Nodes.Add(arbolNodos[13]);
            arbolNodos[6].Nodes.Add(arbolNodos[14]);
        }

        private void BRegresar_Click(object sender, EventArgs e)
        {
            start.Show();
            this.Close();
        }

        private void Adicion_Click(object sender, EventArgs e)
        {
            arbol.Insertar(int.Parse(opciones.Text));
            arbol.RecorrerInOrden(arbol.Raiz);
            resultados.Text = arbol.resultado;
            arbol.resultado = "";
        }

        private void inOrden_Click(object sender, EventArgs e)
        {
            arbol.RecorrerInOrden(arbol.Raiz);
            resultados.Text = arbol.resultado;
            arbol.resultado = "";
        }

        private void preOrden_Click(object sender, EventArgs e)
        {
            arbol.RecorrerPreOrden(arbol.Raiz);
            resultados.Text = arbol.resultado;
            arbol.resultado = "";
        }

        private void postOrden_Click(object sender, EventArgs e)
        {
            arbol.RecorrerPostOrden(arbol.Raiz);
            resultados.Text = arbol.resultado;
            arbol.resultado = "";
        }

        private void Eliminacion_Click(object sender, EventArgs e)
        {
            arbol.Eliminar(int.Parse(opciones.Text));
        }

        private void Busqueda_Click(object sender, EventArgs e)
        {
            int valorABuscar = int.Parse(opciones.Text);
            Nodo resultado = arbol.Buscar(valorABuscar);
            if (resultado != null)
            {
                resultados.Text = $"\nEl valor {valorABuscar} se encontró en el árbol.";
            }
            else
            {
                resultados.Text = $"\nEl valor {valorABuscar} no se encontró en el árbol.";
            }
        }
    }
}
public class Nodo
{
    public int Valor;
    public Nodo HijoIzquierdo;
    public Nodo HijoDerecho;

    public Nodo(int valor)
    {
        Valor = valor;
        HijoIzquierdo = null;
        HijoDerecho = null;
    }
}

public class ArbolBinario
{
    public Nodo Raiz;
    public string resultado = "";
    public void Insertar(int valor)
    {
        if (Raiz == null)
        {
            Raiz = new Nodo(valor);
        }
        else
        {
            InsertarRecursivamente(Raiz, valor);
        }
    }

    private void InsertarRecursivamente(Nodo nodo, int valor)
    {
        if (valor < nodo.Valor)
        {
            if (nodo.HijoIzquierdo == null)
            {
                nodo.HijoIzquierdo = new Nodo(valor);
            }
            else
            {
                InsertarRecursivamente(nodo.HijoIzquierdo, valor);
            }
        }
        else
        {
            if (nodo.HijoDerecho == null)
            {
                nodo.HijoDerecho = new Nodo(valor);
            }
            else
            {
                InsertarRecursivamente(nodo.HijoDerecho, valor);
            }
        }
    }

    public void RecorrerInOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            RecorrerInOrden(nodo.HijoIzquierdo);
            resultado = resultado +"\n" + nodo.Valor;
            RecorrerInOrden(nodo.HijoDerecho);
        }
    }
    public void RecorrerPreOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            resultado = resultado + "\n" + nodo.Valor;
            RecorrerPreOrden(nodo.HijoIzquierdo);
            RecorrerPreOrden(nodo.HijoDerecho);
        }
    }

    public void RecorrerPostOrden(Nodo nodo)
    {
        if (nodo != null)
        {
            RecorrerPostOrden(nodo.HijoIzquierdo); 
            RecorrerPostOrden(nodo.HijoDerecho);
            resultado = resultado + "\n" + nodo.Valor;
        }
    }

    public Nodo Buscar(int valor)
    {
        return BuscarRecursivamente(Raiz, valor);
    }

    private Nodo BuscarRecursivamente(Nodo nodo, int valor)
    {
        if (nodo == null || nodo.Valor.Equals(valor))
        {
            return nodo;
        }

        if (valor.CompareTo(nodo.Valor) < 0)
        {
            return BuscarRecursivamente(nodo.HijoIzquierdo, valor);
        }
        else
        {
            return BuscarRecursivamente(nodo.HijoDerecho, valor);
        }
    }
    private Nodo EliminarRecursivamente(Nodo nodo, int valor)
    {
        if (nodo == null)
        {
            return nodo;
        }

        int comparacion = valor.CompareTo(nodo.Valor);
        if (comparacion < 0)
        {
            nodo.HijoIzquierdo = EliminarRecursivamente(nodo.HijoIzquierdo, valor);
        }
        else if (comparacion > 0)
        {
            nodo.HijoDerecho = EliminarRecursivamente(nodo.HijoDerecho, valor);
        }
        else
        {
            if (nodo.HijoIzquierdo == null && nodo.HijoDerecho == null)
            {
                nodo = null;
            }
            else if (nodo.HijoIzquierdo == null)
            {
                nodo = nodo.HijoDerecho;
            }
            else if (nodo.HijoDerecho == null)
            {
                nodo = nodo.HijoIzquierdo;
            }
            else
            {
                Nodo sucesorInOrden = EncontrarMinimo(nodo.HijoDerecho);
                nodo.Valor = sucesorInOrden.Valor;
                nodo.HijoDerecho = EliminarRecursivamente(nodo.HijoDerecho, sucesorInOrden.Valor);
            }
        }

        return nodo;
    }

    public void Eliminar(int valor)
    {
        Raiz = EliminarRecursivamente(Raiz, valor);
    }

    private Nodo EncontrarMinimo(Nodo nodo)
    {
        while (nodo.HijoIzquierdo != null)
        {
            nodo = nodo.HijoIzquierdo;
        }
        return nodo;
    }
}
