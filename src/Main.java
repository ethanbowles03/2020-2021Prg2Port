import javax.swing.*;
import java.awt.*;
import java.awt.geom.*;
import java.awt.event.*;

/** Main class which runs all of the code
 * @author Ethan Bowles
 * @since March 25, 2021
*/
public class Main{
  public static JFrame frame = new JFrame("Crypto-Miner");

  /**
  * Constructor which sets up the frame for the GUI to go on
  * Adds the animation to the frame
  */
  public Main(){
      frame(1500,600);

      frame.add(new Animation());
      frame.setVisible(true);
    }

  /**
  * Main method which runs all of the other classes to make the final product
  * Adds the stock, upgrade button and cash out button classes
  * @param args - a collection of string to enter in the terminal
  */
  public static void main(String[] args){
      Main main = new Main();
      Stocks s = new Stocks();
      UpgradeButton b = new UpgradeButton();
      CashOut c = new CashOut();
      s.getOpenningStockPrice(UpgradeButton.pubURL,"YMlKec fxKbKc");
  }

  /**
  * The mehtod which sets up the basic properties of the jframe
  * @param x - sets the x dimetion of the frame
  * @param y - sets the y dimetion of the frame
  */
  public void frame(int x, int y){
      frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      frame.setSize(x, y);
      frame.setLocationRelativeTo(null);
    }
}
