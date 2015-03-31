using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class _1
    {
    static boolean condition(){
    boolean result = Math.random()<0.99;
    System.out.print(result+". ");
    return result;
    }
    public static int Faktorial(int x){
    if (x<0) throw new IllegalArgumentException("x должен быть>=0");
    int fact=1;
    for (int i=2; i<=x;i++)
    fact*=i; //
    return fact; //
    }
    public static double Chance(double l, double t, int n){
    double res=Math.pow(Math.E, -l*t)*Math.pow(l*t, n)/Faktorial(n);
    return res;
    }
    public static double lymbda(double N,double M)
    {
    return 10*(M/N);
    }
    public static void main(String []args)throws IOException {
    Scanner read = new Scanner(System.in);
    //1
    System.out.println("Input N,nomer v jyrnale");
    double N = read.nextInt();
    System.out.println("Input m");
    double m = read.nextDouble();
    double l = lymbda(N, m);

    System.out.println(l);
    int n =read.nextInt();
    //double []r={0.75, 0.6, 0.31, 0.09, 0.81};
    double[] r = new double[n];
    for (int i = 0; i < n; ++i) 
    {
        r[i] = Math.random();
    }
    System.out.println(" r[i]");
    for (int i = 0; i < n; ++i) 
    {
        System.out.print(r[i] + " ");
    }
    System.out.println();
    //1
    //2
    System.out.println("zI" + " ");
    double[] z = new double[n];
    for (int i = 0; i < n; ++i) 
    {
        z[i] = (-1 / l) * Math.log(r[i]);
    }
    for (int i = 0; i < n; ++i) 
    {
        System.out.print(z[i] + " ");
    }
    //2
    System.out.println();
    double t1 = N + 1;
    double t2 = N + 5;
    System.out.println("t1=" + t1 + " ");
    System.out.println("t2= " + t2 + " ");
    double[] tk = new double[n];
    double sum=0;

    for (int k = 0; k < n; k++) {
    double x = 0;
    for (int i = 0; i <= k; i++) {
    x += z[i];
    }
    if (x+t1 <= t2)
    tk[k] = t1+x ;
    else break;
    }
    System.out.println("tk");
    for(int i=0;i<n;++i)
    {
    System.out.print(tk[i]+" ");
    }
    System.out.println();
    double tay=(t2-t1)/25;
    System.out.print("tay=" + tay);
    System.out.println();
    double[] masTay=new double[n];

    double newX=t1;

    for(int i=0;i<n;i++)
    {
    masTay[i]=+newX;
    newX+=tay;
    }
    System.out.println("masTay=");
    for(int i=0;i<n;i++)
    {
    System.out.print(masTay[i]+" ");
    }
    System.out.println();
    int count=0;
    int[] countMas=new int [n-1];
    for(int i=0;i<n-1;++i) {
    for (int j = 0; j < n; ++j) {
    if (z[j] > masTay[i] && z[j] < masTay[i + 1])
    count++;
    }
    countMas[i]=count;
    count = 0;
    }
    for(int i=0;i<n-1;++i)
    {
    for (int j = 0; j < n; ++j)
    {
    if (tk[j] > masTay[i] && tk[j] < masTay[i + 1])
    count++;
    }
    countMas[i]=count;
    count = 0;
    }

    System.out.println(Arrays.toString(countMas));

    int maxk=0;
    for(int i=0;i<n-1;++i)
    {
    if(maxk<countMas[i])
    maxk=countMas[i];
    }
    System.out.print("maxk="+maxk);
    System.out.println();

    System.out.println("tabl3");
    int[] nk=new int[maxk+1];

    int nK=0;
    for(int i=0;i<=maxk;++i) {
    for(int j=0;j<n-1;++j)
    {
    if (countMas[j]==i)
    {
    nK++;
    }
    }
    nk[i]=nK;
    nK=0;
    }
    System.out.println(Arrays.toString(nk));
    System.out.println();
    //3.6

    double lymbda2;
    double a;
    int sumN=0;
    for(int i=0;i<=maxk;++i)
    {
    sumN+=nk[i]*i;
    }
    a=(1.0/n)*sumN;
    System.out.print("a="+a);
    System.out.println();
    lymbda2=a/tay;
    System.out.print("lymbda2="+lymbda2);
    System.out.println();
    //3.7
    double t=t2-t1;
    System.out.println("7.1 - Otsytctvie trebovaniy");
    System.out.println("p for lymbda=" + Math.pow(Math.E,-(lymbda(N, m)*t)) );
    System.out.println("p for lymbda2=" + Math.pow(Math.E,-(lymbda2*t) ));

    }
}
