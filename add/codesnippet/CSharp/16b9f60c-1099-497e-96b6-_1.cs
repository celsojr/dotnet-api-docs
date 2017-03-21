        public void DrawPolygonPointF(PaintEventArgs e)
        {
                     
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);
                     
            // Create points that define polygon.
            PointF point1 = new PointF(50.0F,  50.0F);
            PointF point2 = new PointF(100.0F,  25.0F);
            PointF point3 = new PointF(200.0F,   5.0F);
            PointF point4 = new PointF(250.0F,  50.0F);
            PointF point5 = new PointF(300.0F, 100.0F);
            PointF point6 = new PointF(350.0F, 200.0F);
            PointF point7 = new PointF(250.0F, 250.0F);
            PointF[] curvePoints =
                     {
                         point1,
                         point2,
                         point3,
                         point4,
                         point5,
                         point6,
                         point7
                     };
                     
            // Draw polygon curve to screen.
            e.Graphics.DrawPolygon(blackPen, curvePoints);
        }