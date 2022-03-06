
import java.awt.*;
import javax.swing.*;

public class DrawArcs extends JFrame {

    public DrawArcs() 
    {

        super("Drawing Arcs");
        setSize(300, 170);
        setVisible(true);

    }

    @Override
    public void paint(Graphics g) 
    {
        super.paint(g);
        
        g.setColor(Color.YELLOW);
        g.drawRect(15, 35, 80, 80);
        g.setColor(Color.BLACK);
        g.drawArc(15, 35, 80, 80, 0, 360);
        g.setColor(Color.YELLOW);
        g.drawRect(100, 35, 80, 80);
        g.setColor(Color.BLACK);
        g.drawArc(100, 35, 80, 80, 0, 110);
        g.setColor(Color.YELLOW);
        g.drawRect(185, 35, 80, 80);
        g.setColor(Color.BLACK);
        g.drawArc(185, 35, 80, 80, 0, -270);
        g.fillArc(15, 120, 80, 40, 0, 360);
        g.fillArc(100, 120, 80, 40, 270, -90);
        g.fillArc(185, 120, 80, 40, 0, -270);
        
    }
    public static void main(String args[]) {

        DrawArcs application = new DrawArcs();

        application.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
}
