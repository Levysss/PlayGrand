using System.Collections;
using System.Data.SqlTypes;
using System.Text;

public abstract class Pizza
{
    protected string Nome{get;set;}
    protected string massa;
    protected string molho;
    protected ArrayList ingredientes = new ArrayList();

    public string Preparar()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Preparando"+Nome+"\n");
        sb.Append(massa+"\n");
        sb.Append(molho+"\n");
        sb.Append("Ingredientes :"+"\n");
        foreach (string ingrediente in ingredientes)
        {
            sb.Append("\t"+ingrediente+"\n");
        }
        sb.Append(Cozinhar());
        sb.Append(Fatiar());
        sb.Append(Embalar());
        return sb.ToString();
    }
    public virtual string Cozinhar()
    {
        return "Cozinhar por 25 min a 350 gruas \n";
    } 
    public virtual string Fatiar()
    {
        return "Fatiar Pizza em 8 pedaços \n";
    }
    public virtual string Embalar()
    {
        return "Embalar Pizza com embalagem oficial \n";
    }

}