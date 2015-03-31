public  class Point {
    protected double x;
    double y;
    double z;

    public Point(double x, double y) {
        this.x = x;
        this.y = y;
    }
    public Point(double x, double y,double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;

    }
    public Point()
    {
    }

   @Override
    public String toString() {
        return String.format("Class %s, x %f y %f z %f", this.getClass().getSimpleName(), this.x, this.y, this.z);
    }

    public static void main(String[] args) {
        Point p1 = new Point(1.0,1.0);
        Point p0 = new Point(0.0,1.0);
        Circle c1 = new Circle();
        double r = c1.radius(p1,p0);
        System.out.println("Circle radius = " + r);
        double s = c1.square(r);
        System.out.println("Circle Square = " + s);
        Point p2 = new Point(1.0,1.0,1.0);
        Point p3 = new Point(0.0,0.0,0.0);
        Sphere s1 = new Sphere();
        double rs = s1.radius(p2, p3);
        System.out.println("Sphere radius = "+rs);
        double ss = s1.square(rs);
        System.out.println("Sphere Square = " + ss);
        Sphere s2 = new Sphere(1,2,3);
        System.out.println(c1.toString());
        System.out.println(s1.toString());
        System.out.println(s2.toString());


    }



}

