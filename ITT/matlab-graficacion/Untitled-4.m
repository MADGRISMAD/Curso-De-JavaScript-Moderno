[X, Y]=meshgrid(-2:.2:2,-2:0.2:2);
Z = X * exp(-X*X - Y*Y);
surf(X,Y,Z);
title('Madeline Sabino')