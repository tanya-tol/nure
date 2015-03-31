import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.util.Random;

public class Diagram extends JFrame implements ActionListener {
    int arrLength = 3;
    //private DCanvas dCanv;
    private JButton goButton;
    private JTable dataTable;
    private Panel tPanel;
    private JPanel btPanel;
    private JComponent tComponent;

    private CircleComponent circleComponent;

    // Создать класс, наследующий от JComponent. Переопределить в нем метод paint()
    //  Добавить класс на форму: add(new CircleComponent(), BorderLayout.CENTER)

    public Diagram() {
        setTitle("Круговая диаграмма");

        String a = JOptionPane.showInputDialog("Введите число а: ");
        String b = JOptionPane.showInputDialog("Ведите число б: ");
        String c = JOptionPane.showInputDialog("Ведите число c: ");

        int A = Integer.parseInt(a);
        int B = Integer.parseInt(b);
        int C = Integer.parseInt(c);

        //	Указываем менеджер компоновки
        BorderLayout lay = new BorderLayout();
        setLayout(lay);
        dataTable = new JTable(arrLength, 1);
        dataTable.getModel().setValueAt(A, 0, 0);
        dataTable.getModel().setValueAt(B, 1, 0);
        dataTable.getModel().setValueAt(C, 2, 0);

        // 	Размещаем диаграмму
        /*dCanv = new DCanvas();
        int[] arr = new int[arrLength];
        for (int i = 0; i < arrLength; ++i) {
            arr[i] = Integer.valueOf(dataTable.getModel().getValueAt(i, 0).toString());
        }
        int h = this.getHeight()+10;
        int w = this.getWidth()-50;

        dCanv.init(arr, w, h);
        add(dCanv, BorderLayout.EAST);*/

        //tPanel = new Panel();
        //add(tPanel, BorderLayout.WEST);
        //tPanel.add(dataTable);

        btPanel = new JPanel();
        add(btPanel, BorderLayout.SOUTH);

        goButton = new JButton("Показать диаграмму");
        goButton.addActionListener(this);
        btPanel.add(goButton);

        circleComponent = new CircleComponent();
        add(circleComponent, BorderLayout.CENTER);

        setSize(430, 410);
        setVisible(true);
    }

    //	Обработчик события
    public void actionPerformed(ActionEvent e) {
        /*if (e.getSource()==goButton)*/
        {
            int[] arr = new int[arrLength];
            for (int i = 0; i < arrLength; i++) {
                arr[i] = Integer.valueOf(dataTable.getModel().getValueAt(i, 0).toString());
            }
            int h = this.getHeight() + 10;
            int w = this.getWidth() - 50;

            circleComponent.setData(arr, w, h);
        }
    }

    public static void main(String[] args) {
        new Diagram();
    }

}

class CircleComponent extends JComponent {

    int w, h;
    int[] data;
    Color[] colors;

    public void setData(int[] arr, int width, int height) {
        int i, r, g, b;

        this.data = new int[arr.length];
        this.colors = new Color[arr.length];
        Random rnd = new Random();
        this.w = width;
        this.h = height;

        for (i = 0; i < data.length; i++) {
            r = rnd.nextInt(255);
            g = rnd.nextInt(255);
            b = rnd.nextInt(255);

            this.colors[i] = new Color(r, g, b);
            this.data[i] = arr[i];
        }

        repaint();
    }

    public void paint(Graphics g) {
        super.paint(g);

        if (colors != null) {

            int x, y, size, i;

            x = w / 2;
            y = h / 2;
            size = Math.min(x, y) - 1;

            int summa = 0;
            for (i = 0; i < data.length; i++) {
                summa += data[i];
            }

            int fi = 0, psi;
            for (i = 0; i < data.length; i++) {
                psi = data[i] * 360 / summa;
                g.setColor(colors[i]);
                g.fillArc(x - size, y - size, 2 * size, 2 * size, fi, psi);
                g.setColor(Color.black);
                g.drawString(Integer.toString(i + 1) + " строка (" + new Integer((int) data[i] * 100 / summa).toString() + " %)", x + (int) ((size * Math.cos((fi + psi / 2) * Math.PI / 180) / 1.5)), y - (int) ((size * Math.sin((fi + psi / 2) * Math.PI / 180) / 1.5)));
                g.drawLine(x, y, x + (int) (size * Math.cos(fi * Math.PI / 180)), y - (int) (size * Math.sin(fi * Math.PI / 180)));
                fi += psi;
            }
            g.drawOval(x - size, y - size, 2 * size, 2 * size);
        }
    }
}
