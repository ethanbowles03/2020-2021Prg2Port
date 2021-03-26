import javax.swing.*;
import java.awt.*;
import java.awt.geom.*;
import java.awt.event.*;

/** Class which add the labels at the top of the screen
 * @author Ethan Bowles
 * @since March 25, 2021
*/
public class Labels{
  public static double totalVal = 0;
  public static double totalCash = 0;
  private static JLabel totalLabel = new JLabel();
  public static JLabel cryptoLabel = new JLabel();
  public static JLabel cashLabel = new JLabel();
  private static Stocks stock = new Stocks();

  /**
  * Constructor which sets up the labels and their outline
  */
  public Labels(){
    setTotalLabel();
    setCryptoLabel();
    setCashLabel();
  }

  /**
  * Method to update the totalLabel
  */
  public static void totalLabel(){
    totalLabel.setText("Total Crypto: " + String.valueOf(totalVal));
  }

  /**
  * Method to update the cashLabel
  */
  public static void cashLabel(){
    cashLabel.setText("Total Cash: " + String.valueOf(totalCash));
  }

  /**
  * Method which setes the fonts of the total label and the bounds
  * It is then added to the screen
  */
  public void setTotalLabel(){
    totalLabel.setFont(new Font("Serif", Font.PLAIN, 20));
    totalLabel.setBorder(BorderFactory.createLineBorder(Color.black));
    totalLabel.setHorizontalAlignment(SwingConstants.CENTER);
    totalLabel.setBounds(10,10,300,50);
    Main.frame.add(totalLabel);
  }

  /**
  * Method which setes the fonts of the crypto label and the bounds
  * It is then added to the screen
  */
  public void setCryptoLabel(){
    cryptoLabel.setFont(new Font("Serif", Font.PLAIN, 20));
    cryptoLabel.setBorder(BorderFactory.createLineBorder(Color.black));
    cryptoLabel.setHorizontalAlignment(SwingConstants.CENTER);
    cryptoLabel.setBounds(590,10,300,50);
    Main.frame.add(cryptoLabel);
  }

  /**
  * Method which setes the fonts of the CASH label and the bounds
  * It is then added to the screen
  */
  public void setCashLabel(){
    cashLabel.setFont(new Font("Serif", Font.PLAIN, 20));
    cashLabel.setBorder(BorderFactory.createLineBorder(Color.black));
    cashLabel.setHorizontalAlignment(SwingConstants.CENTER);
    cashLabel.setBounds(1125,10,300,50);
    Main.frame.add(cashLabel);
    cashLabel.setText("Total Cash: " + String.valueOf(totalCash));
  }
}
