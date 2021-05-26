import javax.swing.*;
import java.awt.*;
import java.awt.geom.*;
import java.awt.event.*;


/** Class in charge of putting the bars on the screen and animating them
 * @author Ethan Bowles
 * @since March 25, 2021
*/
public class Animation extends JComponent{
  public static Bars bar1 = new Bars(75,100,"Cheap Graphics Card");
  public static Bars bar2 = new Bars(75,200,"High-End Graphics Card");
  public static Bars bar3 = new Bars(75,300,"ASIC Miner");
  public static Bars bar4 = new Bars(75,400,"Mining Rack");
  public static Bars bar5 = new Bars(825,100,"Supre Computer");
  public static Bars bar6 = new Bars(825,200,"Data Center");
  public static Bars bar7 = new Bars(825,300,"Satalite Miner");
  public static Bars bar8 = new Bars(825,400,"Planet Miner");

  /**
  * Constructor for the Animation Class
  * Instantiates the labels and the first button on the screen for the user to
  * start the simulation
  * Creates a timer to run the animation on until the program is closed
  */
  public Animation(){
    Labels l = new Labels();
    firstButton();
    Thread animationThread = new Thread(new Runnable() {
        public void run() {
            while (true) {
                try {Thread.sleep(1);} catch (Exception ex) {}
            }
        }
    });
    animationThread.start();
  }

  /**
  * Puts the first button onto the screen for the user to start the game
  */
  public void firstButton(){
    Buttons buttons = new Buttons(45,100);
    buttons.buttonOneStart();
  }

  /**
  * Method which updates the painted component on the screen
  * Updates the animation of all of the bar which are active
  * Methods is called every 1 millisecodns and repaints
  * Stock label is set along with total label set to 0
  * @param g - the graphics components for the bars
  */
  @Override
  public void paintComponent(Graphics g) {
    Graphics2D gg = (Graphics2D) g;
    super.paintComponent(gg);
    bar1.bar(gg, 0.5, 0.1,0);
    bar2.bar(gg, 0.25, 6.0,1);
    bar3.bar(gg, 0.125, 54.0,2);
    bar4.bar(gg, 0.0625, 432.0,3);
    bar5.bar(gg, 0.03125, 5184.0,4);
    bar6.bar(gg, 0.015625, 62208.0,5);
    bar7.bar(gg, 0.0078125, 746400.0,6);
    bar8.bar(gg, 0.00390625, 8957900.0,7);
    Labels.totalLabel();
    Stocks.getStockPrice(UpgradeButton.pubURL,"YMlKec fxKbKc");
    repaint();
  }
}
