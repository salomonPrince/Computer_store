//--------------------------------  	
// c# Project (420-CT2-AS C2)
// © Salomon Bulambo
// Written by: Salomon Bulambo 2133726
//----------------------------------  	

public class Computer {

    private String brand; // this is an attribute that is used to store the brand of the computer
    private String model;
    private long  serialnumber;

    private double price;

    private static int numberOfpc = 0;

    private static long serialnumberCount = 1_000_000;
     
    public Computer(){ // this is a constructor that is used to create a computer object
        Console.WriteLine("The Computer object is created ");
        this.brand="Windows"; 
        this.model = "Intel core i8";
        serialnumberCount++;
        this.serialnumber = serialnumberCount;
        this.price = 1299.99;
        numberOfpc ++; 
    }

    public Computer (String bd,String mo,long sn, double pr){ // this is a constructor that is used to create a computer object
        Console.WriteLine("the Computer object is created!!");
        brand = bd;
        model = mo;
        serialnumber = sn;
        price = pr;
        numberOfpc ++; 
    }

    public String getbrand(){
        return this.brand;
    }

    public void setbrand(String brand){
       
            this.brand = brand;
       
    }

 public String getmodel(){
        return this.model;
    }

    public void setmodel(String model){
       
            this.model = model;
    }

    public long getserialnumber(){
        return this.serialnumber;
    }

    public void setserialnumber(long sn) {
        if(sn >= 1_000_000)
          this.serialnumber = sn;
        else
          Console.WriteLine("Serial Number (serialnumber) must not be under seven integers !!");
    }


    public double getprice(){
      return this.price;

    }

    public void setprice (double price) {
        if(price >= 0)
         this.price = price;
        else
          Console.WriteLine("The entered amount is not valid !!");
          Console.WriteLine("-----------------------------------");
    }


      public void showComputer(){ 
        Console.WriteLine(" Computer :");
        Console.WriteLine($"\tComputer_Brand: {this.brand}");
        Console.WriteLine($"\tComputer_Model: {this.model}");
        Console.WriteLine($"\tComputer_SerialNumber:  {this.serialnumber}");
        Console.WriteLine($"\tComputer_Price: ${this.price}");
    //  Console.WriteLine($"the number of Computer generated is: ${this.numberOfpc}");
        Console.WriteLine("---------------------------------------------");
    }

    public static int findNumberOfCreatedComputers(){
        return numberOfpc;
    }

    public bool equels(Computer pc1){
        if (this.brand == pc1.getbrand() &&
            this.model == pc1.getmodel() &&
            this.serialnumber == pc1.getserialnumber() &&
            this.price == pc1.getprice()) 
            {
                return true;
            }else {
                return false;
            }
    }

}
