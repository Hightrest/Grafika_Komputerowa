package lab1;

import java.awt.*;
import javax.swing.*;
import java.awt.geom.AffineTransform;

public class TransformedShapes extends JPanel 
{

	private static final long serialVersionUID = 1L;

	private Graphics2D g2;

	private void resetTransform() 
	{
		g2.setTransform(new AffineTransform());
	}

	private void circle() 
	{
		g2.fillOval(-50,-50,100,100);
	}

	private void square() 
	{
		g2.fillRect( -50, 50, 100,100);
	}

	protected void paintComponent(Graphics g) 
	{
		super.paintComponent(g);
		g2 = (Graphics2D) g.create();
		g2.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);

		g2.translate(300, 300);
		g2.scale(2, 2); 
		g2.setColor(Color.BLACK);
		circle();

		resetTransform();

		g2.translate(300, 300);
		g2.scale(1, 1);
		g2.translate(150, 50);
		g2.setColor(Color.YELLOW);
		square();

	}

	public TransformedShapes() 
	{
		setPreferredSize(new Dimension(600, 600));
		setBackground(Color.WHITE);
		setBorder(BorderFactory.createLineBorder(Color.BLACK, 4));
	}

	public static void main(String[] args) 
	{
		JFrame window = new JFrame("Drawing With Transforms");
		window.setContentPane(new TransformedShapes());
		window.pack();
		window.setResizable(false);
		window.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		Dimension screen = Toolkit.getDefaultToolkit().getScreenSize();
		window.setLocation((screen.width - window.getWidth()) / 2, (screen.height - window.getHeight()) / 2);
		window.setVisible(true);
	}

}