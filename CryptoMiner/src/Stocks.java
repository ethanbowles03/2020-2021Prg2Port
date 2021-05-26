import java.io.*;
import java.net.*;
import java.util.*;


/** Stock class to get stock prices from the internet
 * @author Ethan Bowles
 * @since March 25, 2021
*/
public class Stocks{
  public final static String BTC = "BTC";

  /** Method which gets the stock price from internetand sets the labels to them
  * @param urlName - the string which gives the code the place to get the price of the Stock
  * @param filter - the filter to find the price in the HTML code
  */
  public static void getStockPrice(String urlName, String filter){
    int a =0;
    GregorianCalendar gcalendar = new GregorianCalendar();
    if(gcalendar.get(Calendar.SECOND) == 0  && (gcalendar.get(Calendar.MINUTE)%5) == 0){
      try{
        URL url = new URL(urlName);
        URLConnection urlConn = url.openConnection();
        InputStreamReader in = new InputStreamReader(urlConn.getInputStream());
        BufferedReader buff = new BufferedReader(in);
        String line = buff.readLine();
        String price = "not found";
        while(line != null){
          if(line.contains(filter)){
            int target =line.indexOf(filter);
            int deci = line.indexOf(".", target);
            int start = deci;
            while(line.charAt(start) != '>'){
              start--;
            }
            price = line.substring(start + 1, deci + 3);
          }
          line = buff.readLine();
        }
        Labels.cryptoLabel.setText(UpgradeButton.pubLab + " : " + price);
      }catch(Exception e){
        System.out.println("error");
      }
    }
  }

  /** Method which gets the stock price from internetand sets the labels to them however mainly to open
  * @param urlName - the string which gives the code the place to get the price of the Stock
  * @param filter - the filter to find the price in the HTML code
  */
  public static void getOpenningStockPrice(String urlName, String filter){
    try{
      URL url = new URL(urlName);
      URLConnection urlConn = url.openConnection();
      InputStreamReader in = new InputStreamReader(urlConn.getInputStream());
      BufferedReader buff = new BufferedReader(in);
      String line = buff.readLine();
      String price = "not found";
      while(line != null){
        if(line.contains(filter)){
          int target =line.indexOf(filter);
          int deci = line.indexOf(".", target);
          int start = deci;
          while(line.charAt(start) != '>'){
            start--;
          }
          price = line.substring(start + 1, deci + 3);
        }
        line = buff.readLine();
      }
      Labels.cryptoLabel.setText(UpgradeButton.pubLab + " : " + price);
    }catch(Exception e){
      System.out.println("error");
    }
  }
}
