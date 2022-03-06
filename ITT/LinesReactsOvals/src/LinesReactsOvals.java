import java.awt.*;
import javax.swing.*;

public class LinesReactsOvals extends JFrame{
    public LinesReactsOvals()
    {
        super("drawing lines, rectanlges and ovals");
        setSize(400,165);
        setVisible(true);
    }
    @Override
    public void paint(Graphics g)
    {
        super.paint(g);
        g.setColor(Color.RED);
        g.drawLine(5,30,350,30);
        g.setColor(Color.blue);
        g.drawRect(5,40,90,55);
        g.fillRect(100,40,90,55);
        g.setColor(Color.cyan);
        g.fillRoundRect(195,40,90,55,50,50);  
        
        g.drawRoundRect(290,40,90,55,20,20);
        g.setColor(Color.yellow);
        g.draw3DRect(5,100,90,55,true);
        g.fill3DRect(100,100,90,55,false);
        
    }
    public static void main(String args[])
    {
        LinesReactsOvals application = new LinesReactsOvals();
        application.setDefaultCloseOperation( JFrame.EXIT_ON_CLOSE );
        
        
    }
}

   

