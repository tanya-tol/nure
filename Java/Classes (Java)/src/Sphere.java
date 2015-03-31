public class Sphere extends Point {
    public Sphere(double x, double y, double z) {
        super(x, y, z);
    }//super - ссылка на базовый класс
    public Sphere()
    {

    }
    
    public static double radius(Point p0,Point p1)
    {
        double r = 0;
        r = Math.sqrt(Math.pow(((p1.x) - (p0.x)),2) + Math.pow(((p1.y) - (p0.y)),2) + Math.pow(((p1.z)-(p0.z)),2));
        return r;
    }

    public static double square(double r)
    {
        double s = 0;
        s = 4*Math.PI*Math.pow(r,2);
        return s;

    }

}
