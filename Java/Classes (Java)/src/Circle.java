public class Circle extends Point{
    public Circle(double x, double y) {
        super(x, y);
    }
    public Circle()
    {

    }

    public static double radius(Point p1,Point p0 )
    {
        double r = 0;
        r = Math.sqrt(Math.pow(((p1.x)-(p0.x)),2)+Math.pow(((p1.y)-(p0.y)),2));
        return r;
    }

    public static double square(double r)
    {
        double s = 0;
        s = Math.PI*Math.pow(r,2);
        return s;
    }

}
