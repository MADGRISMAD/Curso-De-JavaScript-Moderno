x = 0:pi/100:3*pi;
y = sin(x);
plot(x,y)
hold on
y2 = cos(x);
plot(x,y2,':')
legend('sin','cos')
hold off
title('Madeline Sabino')