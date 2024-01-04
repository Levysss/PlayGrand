using System.Collections;

public abstract class MassaBase
{
    public TipoMassa TipoMasa {get;set;}
    public string Nome {get;set;}
    public ArrayList ingredientes = new ArrayList();
    public MassaBase(string nome,TipoMassa tipo)
    {
        Nome= nome;
        TipoMasa = tipo;
    }
}