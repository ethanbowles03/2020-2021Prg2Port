import javax.swing.*;
import java.awt.*;
import java.awt.geom.*;
import java.awt.event.*;

/** Class which sets the dimentions of the bars and all the other components of each bar
 * @author Ethan Bowles
 * @since March 25, 2021
*/
public class Bars extends JComponent{
  //public variables
  public boolean unlocked = false;
  public static int[] own = new int[8];

  //private variables
  private double lastX = 0;
  private int xLoc = 0;
  private int yLoc = 0;
  private boolean activeLabel = true;
  private boolean activeUpLabel = true;
  private String title = "";

  /**
  * Constructor for the Bars Class
  * Sets the location of the bars and the titles listed above them
  * Instantiates the amount of each miner the user owns to 0
  * @param xLoc - the x location on the screen
  * @param yLoc - the y location on the screen
  * @param title - the title of the miner on the screen
  */
  public Bars( int xLoc, int yLoc, String title){
    this.xLoc = xLoc;
    this.yLoc = yLoc;
    this.title = title;
    for(int i = 0; i < own.length; i++){
      own[i] = 1;
    }
    own[0] = 0;
    setLayout();
  }

  /**
  * Method which puts the title of the miner on the screen and makes sure to only
  * do it one time
  * @param titel - the title of the label
  */
  private void setLabel(String title){
    if(activeLabel){
      JLabel label = new JLabel();
      label.setText(title);
      label.setHorizontalAlignment(SwingConstants.CENTER);
      label.setBounds(xLoc,yLoc - 25,602,25);
      Main.frame.add(label);
      activeLabel = false;
    }
  }

  /**
  * Method that sets the screen layout to CENTER
  */
  private void setLayout(){
    JButton layout = new JButton();
    layout.setBounds(0,0,0,0);
    Main.frame.add(layout, BorderLayout.CENTER);
  }

  /**
  * Method which puts the screen and calls the label method above
  * Uses the speed passed in to calculate the new distance of the bar
  * Adds the value to the total crypto once the bar reaches the end
  * @param gg - the graphics component
  * @param speed - the speed at which the bar should move per millisecond
  * @param value - the value added when the bar reaches the end
  * @param id - the id to keep track of the bar
  */
  public void bar(Graphics2D gg, double speed, double value, int id){
    if(unlocked){
      double x = lastX + speed;

      if (x > 602) {
          x = 0;
          Labels.totalVal += (value * own[id]);
      }

      Rectangle2D rect = new Rectangle2D.Double(xLoc, yLoc, x, 50);
      Rectangle2D rectOutline = new Rectangle2D.Double(xLoc, yLoc, 600, 50);

      gg.setColor(Color.BLACK);
      gg.draw(rectOutline);
      gg.setColor(new Color(178,194,172));
      gg.fill(rect);

      lastX = x;
      setLabel(title);
    }
  }
}
