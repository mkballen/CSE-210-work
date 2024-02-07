class Fraction
{
    //declaring a numerator (top) and denominator (bottom)
    private int top;
    private int bottom;

    public Fraction(){
        top = 1;
        bottom = 1;
    }
    public Fraction(int wholeNum){
        top = wholeNum;
        bottom = 1;
    }
    public Fraction(int atop, int abottom){
        top = atop;
        bottom = abottom;
    }

    //show fraction
    public string GetFractionString(){
        
        return $"{top}/{bottom}";
    }
    //show decimal
    public double GetDecimalValue(){
        double atop = (double)top;
        double abottom = (double)bottom;
        double deci = atop / abottom;
        return deci;
    }
}