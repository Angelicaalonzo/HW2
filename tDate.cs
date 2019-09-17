using System;


class tDate{
public string earliestDate = "1/1/1900"; 


public string LatestDate= "12/31/2100";
public int day; 
public int month; 
public int year; 



    public tDate(int mm, int dd, int yy)
    {
        if((mm > 0 && mm<= 12) &&(dd> 0 && dd <=31) && (yy>0) ){

        Console.WriteLine("{0},{1},{2}",mm, dd, yy);
        }
        else
        {
            String[] splitEarly = earliestDate.Split('/');
            int _month = Convert.ToInt32(splitEarly[0]);
            int _day = Convert.ToInt32(splitEarly[1]);
            int _year = Convert.ToInt32(splitEarly[2]);

            Console.WriteLine("{0},{1},{2}",_month, _day,year);


        }

    }
    public tDate(string date)
    {
        date.Split('/');
        string[] dateComp = date.Split('/');
        month = Convert.ToInt32(dateComp[0]);
        day = Convert.ToInt32(dateComp[1]);
        year = Convert.ToInt32(dateComp[2]);

    if((month > 0 && month<= 12) &&(day> 0 && day <=31) && (year>0) ){

        Console.WriteLine("{0},{1},{2}",month, day, year);
    }else{
        
         String[] splitEarly = earliestDate.Split('/');
            int _month = Convert.ToInt32(splitEarly[0]);
            int _day = Convert.ToInt32(splitEarly[1]);
            int _year = Convert.ToInt32(splitEarly[2]);

            Console.WriteLine("{0},{1},{2}",_month, _day,year);


    }

    }

   

    

}
