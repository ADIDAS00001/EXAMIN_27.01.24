namespace ex7;

public class Matematika
{
    public double pi =3.14;
    public double e =2.71;
    public double  Abs(double value)
    {
       return Math.Abs(value);
    }
    public double Abs(float value)
    {
        return Math.Abs(value);
    }
     public double Abs(int value)
    {
        return Math.Abs(value);
    }
    public double Pow(double x,double y)
    {
        return Math.Pow(x,y);
        // for(int i=0;i<=y;i++)
        // {
        //     return x*x;
        // }
        // return y ;
    }
    public double Sqrt(double d)
    {
        for(int i=0;i<d;i++)
        {
            if(i*i==d)
            {
                return  i;
            }
            else if(i*i>=d)
            {
                System.Console.WriteLine("Nest:");
            }
        }    
        return d;

    }
    public int Max(int val1, int val2)
    {
        if(val1>val2){return val1;}
        else {return val2;}
    }
     public int Min(int val1, int val2)
    {
        if(val1>val2){return val2;}
        else {return val1;}
    } 

}

