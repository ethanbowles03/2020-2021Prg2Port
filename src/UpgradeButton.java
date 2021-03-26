import javax.swing.*;
import java.awt.*;
import java.awt.geom.*;
import java.awt.event.*;

/** Class which is a button to upgrade between different crypto currencies
 * @author Ethan Bowles
 * @since March 25, 2021
*/
public class UpgradeButton extends JButton implements ActionListener{
  private String[] urls = new String[4];
  private String[] labels = new String[4];
  private boolean[] checks = new boolean[3];
  public static String pubURL = "https://www.google.com/finance/quote/LTC-USD";
  public static String pubLab = "LTC";
  private int count = 0;

  /**
  * Constructor which sets the bounds of the button and adds it to the JFrame
  * Sets the urls with url method
  */
  public UpgradeButton(){
    setUrls();
    pubURL = urls[0];
    this.setBounds(1365,530,75,50);
    this.setText("Upgrade");
    this.setFocusPainted(false);
    addActionListener(this);
    Main.frame.setLayout(null);
    Main.frame.add(this);
  }

  /**
  * Methods which sets the urls and the corresponding tags for each
  */
  private void setUrls(){
    urls[0] = "https://www.google.com/finance/quote/LTC-USD";
    urls[1] = "https://www.google.com/finance/quote/BCH-USD";
    urls[2] = "https://www.google.com/finance/quote/ETH-USD";
    urls[3] = "https://www.google.com/finance/quote/BTC-USD";
    labels[0] = "LTC";
    labels[1] = "BHC";
    labels[2] = "ETH";
    labels[3] = "BTC";
    for(int i = 0; i < checks.length; i++){
      checks[i] = false;
    }
  }

  /**
  * Methods which takes input from the button and determines which crypto chould be displayed on the screen
  * @param e - the input from the button
  */
  @Override
  public void actionPerformed(ActionEvent e) {
    if(e.getSource() == this){
      if(count >= 3){
        Stocks.getStockPrice(pubURL,"YMlKec fxKbKc");
      }
      else if(count == 2){
        checks[2] = Labels.totalCash > 10000000 ? true : false;
        if(checks[2] == true){
          count++;
          pubURL = urls[count];
          pubLab = labels[count];
          Stocks.getOpenningStockPrice(pubURL,"YMlKec fxKbKc");

          repaint();
        }
      }
      else if(count == 1){
        checks[1] = Labels.totalCash > 100000 ? true : false;
        if(checks[1] == true){
          count++;
          pubURL = urls[count];
          pubLab = labels[count];
          Stocks.getOpenningStockPrice(pubURL,"YMlKec fxKbKc");

          repaint();
        }
      }
      else if(count == 0){
        checks[0] = Labels.totalCash > 10000? true : false;
        if(checks[0] == true){
          count++;
          pubURL = urls[count];
          pubLab = labels[count];
          Stocks.getOpenningStockPrice(pubURL,"YMlKec fxKbKc");

          repaint();
        }
      }else{

      }
    }
  }
}
