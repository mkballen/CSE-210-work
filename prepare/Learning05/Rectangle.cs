class Rectangle : Shape {
    private double length;
    private double width;

    public Rectangle(string colour, double length1, double width1) : base(coolour){
        length = length1;
        width = width1;
    }
    public override double GetArea(){
        return length * width;
    }
}
