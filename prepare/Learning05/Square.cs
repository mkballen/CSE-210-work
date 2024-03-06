class Square : Shape{

    private double side;


    public Square(double side_1, string colour) : base(colour){
        side = side_1;
    }
    public override double GetArea(){
        
        return side * side;
    }
}