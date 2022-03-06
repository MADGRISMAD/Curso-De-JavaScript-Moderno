import java.awt.*;
import javax.swing.*;

public class Metrics extends JFrame {

// set window's title bar and dimensions
    public Metrics() {

        super("Demonstrating FontMetrics");

        setSize(510, 500);

        setVisible(true);

    }

// display Strings in different fonts and
    @Override
    public void paint(Graphics g) {

// call superclass's paint method
        super.paint(g);

        g.setFont(new Font("SansSerif", Font.BOLD, 12));
        FontMetrics metrics = g.getFontMetrics();
        g.drawString("Current font: " + g.getFont(), 10, 50);
        g.drawString("Ascent: " + metrics.getAscent(), 10, 65);
        g.drawString("Descent: " + metrics.getDescent(), 10, 80);
        g.drawString("Height: " + metrics.getHeight(), 10, 95);
        g.drawString("Leading: " + metrics.getLeading(), 10, 110);

        Font font = new Font("Serif", Font.ITALIC, 14);
        metrics = g.getFontMetrics(font);
        g.setFont(font);
        g.drawString("Current font: " + font, 10, 130);
        g.drawString("Ascent: " + metrics.getAscent(), 10, 145);
        g.drawString("Descent: " + metrics.getDescent(), 10, 160);
        g.drawString("Height: " + metrics.getHeight(), 10, 175);
        g.drawString("Leading: " + metrics.getLeading(), 10, 190);

    } // end method paint

// execute application
    public static void main(String args[]) {

        Metrics application = new Metrics();

        application.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

    }

} // end class
