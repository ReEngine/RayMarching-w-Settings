using System;

namespace SmthRender
{
    internal class Render
    {
        public static int maxSteps = 100;
        public static double minDistance = 0.01;
        public static double maxDistance = 100;

        //Параметры сферы
        public static double SphereX = 0;
        public static double SphereY = 1.5;
        public static double SphereZ = 6;
        public static double SphereR = 1;

        //Параметры источника света
        public static double LightX = 0;
        public static double LightY = 1.5;
        public static double LightZ = 6;
        public static double LightD = 70.5; //Множитель диффузии света

        //Параметры анимации для сферы;
        public static double SphereAnimX = 3;
        public static double SphereAnimY = 0.5;
        public static double SphereAnimZ = 3;
        public static double SphereAnimR = 0;
        //private static readonly double LightAnimX = -1;
        //private static readonly double LightAnimY = 0;
        //private static readonly double LightAnimZ = -1;
        //private static readonly double LightAnimD = 0;

        public static bool invertRender = false;


        public static double counter;
        private static readonly Vector3D camera = new Vector3D(0, 1, 1);
        private static readonly Vector3D NormalX = new Vector3D(0.01, 0, 0);
        private static readonly Vector3D NormalY = new Vector3D(0, 0.01, 0);
        private static readonly Vector3D NormalZ = new Vector3D(0, 0, 0.01);


        //0);





        public static void RunTestScene()
        {

            Console.SetCursorPosition(0, 0);
            counter += 0.05;
            Console.BackgroundColor = ConsoleColor.Black;

            //Console.Clear();
            Vector3D rayDirection;

            string renderString = null;

            for (int y = Grid.Height / 2; y > -Grid.Height / 2; y--)
            {
                for (int x = Grid.Width / 2; x > -Grid.Width / 2; x--)
                {
                    Vector3D pixelDrawing = new Vector3D(x, y, 80);
                    rayDirection = Vector3D.Subtract(pixelDrawing, camera).Normalize();
                    double d = RayMarch(camera, rayDirection);

                    Vector3D point = Vector3D.Add(camera, Vector3D.Multiply(rayDirection, d));
                    double LightDiffuse = GetLight(point);

                    LightDiffuse *= LightD;

                    for (int i = 0; i < 2; i++)
                    {
                        if (LightDiffuse < 1)
                        {
                            renderString += ' ';
                        }

                        if ((LightDiffuse >= 1) & (LightDiffuse < 2))
                        {
                            renderString += '.';
                        }

                        if ((LightDiffuse >= 2) & (LightDiffuse < 3))
                        {
                            renderString += '\'';
                        }

                        if ((LightDiffuse >= 3) & (LightDiffuse < 4))
                        {
                            renderString += '`';
                        }

                        if ((LightDiffuse >= 4) & (LightDiffuse < 5))
                        {
                            renderString += '^';
                        }

                        if ((LightDiffuse >= 5) & (LightDiffuse < 6))
                        {
                            renderString += ' ';
                        }

                        if ((LightDiffuse >= 6) & (LightDiffuse < 7))
                        {
                            renderString += '"';
                        }

                        if ((LightDiffuse >= 7) & (LightDiffuse < 8))
                        {
                            renderString += ',';
                        }

                        if ((LightDiffuse >= 8) & (LightDiffuse < 9))
                        {
                            renderString += ':';
                        }

                        if ((LightDiffuse >= 9) & (LightDiffuse < 10))
                        {
                            renderString += ';';
                        }

                        if ((LightDiffuse >= 10) & (LightDiffuse < 11))
                        {
                            renderString += 'I';
                        }

                        if ((LightDiffuse >= 11) & (LightDiffuse < 12))
                        {
                            renderString += 'l';
                        }

                        if ((LightDiffuse >= 12) & (LightDiffuse < 13))
                        {
                            renderString += '!';
                        }

                        if ((LightDiffuse >= 13) & (LightDiffuse < 14))
                        {
                            renderString += 'i';
                        }

                        if ((LightDiffuse >= 14) & (LightDiffuse < 15))
                        {
                            renderString += '>';
                        }

                        if ((LightDiffuse >= 15) & (LightDiffuse < 16))
                        {
                            renderString += '<';
                        }

                        if ((LightDiffuse >= 16) & (LightDiffuse < 17))
                        {
                            renderString += '~';
                        }

                        if ((LightDiffuse >= 17) & (LightDiffuse < 18))
                        {
                            renderString += '+';
                        }

                        if ((LightDiffuse >= 18) & (LightDiffuse < 19))
                        {
                            renderString += '_';
                        }

                        if ((LightDiffuse >= 19) & (LightDiffuse < 20))
                        {
                            renderString += '-';
                        }

                        if ((LightDiffuse >= 20) & (LightDiffuse < 21))
                        {
                            renderString += '?';
                        }

                        if ((LightDiffuse >= 21) & (LightDiffuse < 22))
                        {
                            renderString += ']';
                        }

                        if ((LightDiffuse >= 22) & (LightDiffuse < 23))
                        {
                            renderString += '[';
                        }

                        if ((LightDiffuse >= 23) & (LightDiffuse < 24))
                        {
                            renderString += '}';
                        }

                        if ((LightDiffuse >= 24) & (LightDiffuse < 25))
                        {
                            renderString += '{';
                        }

                        if ((LightDiffuse >= 25) & (LightDiffuse < 26))
                        {
                            renderString += '1';
                        }

                        if ((LightDiffuse >= 26) & (LightDiffuse < 27))
                        {
                            renderString += ')';
                        }

                        if ((LightDiffuse >= 27) & (LightDiffuse < 28))
                        {
                            renderString += '(';
                        }

                        if ((LightDiffuse >= 28) & (LightDiffuse < 29))
                        {
                            renderString += '|';
                        }

                        if ((LightDiffuse >= 29) & (LightDiffuse < 30))
                        {
                            renderString += '\\';
                        }

                        if ((LightDiffuse >= 30) & (LightDiffuse < 31))
                        {
                            renderString += '/';
                        }

                        if ((LightDiffuse >= 31) & (LightDiffuse < 32))
                        {
                            renderString += 't';
                        }

                        if ((LightDiffuse >= 32) & (LightDiffuse < 33))
                        {
                            renderString += 'f';
                        }

                        if ((LightDiffuse >= 33) & (LightDiffuse < 34))
                        {
                            renderString += 'j';
                        }

                        if ((LightDiffuse >= 34) & (LightDiffuse < 35))
                        {
                            renderString += 'r';
                        }

                        if ((LightDiffuse >= 35) & (LightDiffuse < 36))
                        {
                            renderString += 'x';
                        }

                        if ((LightDiffuse >= 36) & (LightDiffuse < 37))
                        {
                            renderString += 'n';
                        }

                        if ((LightDiffuse >= 37) & (LightDiffuse < 38))
                        {
                            renderString += 'u';
                        }

                        if ((LightDiffuse >= 38) & (LightDiffuse < 39))
                        {
                            renderString += 'v';
                        }

                        if ((LightDiffuse >= 39) & (LightDiffuse < 40))
                        {
                            renderString += 'c';
                        }

                        if ((LightDiffuse >= 40) & (LightDiffuse < 41))
                        {
                            renderString += 'z';
                        }

                        if ((LightDiffuse >= 41) & (LightDiffuse < 42))
                        {
                            renderString += 'X';
                        }

                        if ((LightDiffuse >= 42) & (LightDiffuse < 43))
                        {
                            renderString += 'Y';
                        }

                        if ((LightDiffuse >= 43) & (LightDiffuse < 44))
                        {
                            renderString += 'U';
                        }

                        if ((LightDiffuse >= 44) & (LightDiffuse < 45))
                        {
                            renderString += 'J';
                        }

                        if ((LightDiffuse >= 45) & (LightDiffuse < 46))
                        {
                            renderString += 'C';
                        }

                        if ((LightDiffuse >= 46) & (LightDiffuse < 47))
                        {
                            renderString += 'L';
                        }

                        if ((LightDiffuse >= 47) & (LightDiffuse < 48))
                        {
                            renderString += 'Q';
                        }

                        if ((LightDiffuse >= 48) & (LightDiffuse < 49))
                        {
                            renderString += '0';
                        }

                        if ((LightDiffuse >= 49) & (LightDiffuse < 50))
                        {
                            renderString += 'O';
                        }

                        if ((LightDiffuse >= 50) & (LightDiffuse < 51))
                        {
                            renderString += 'Z';
                        }

                        if ((LightDiffuse >= 51) & (LightDiffuse < 52))
                        {
                            renderString += 'm';
                        }

                        if ((LightDiffuse >= 52) & (LightDiffuse < 53))
                        {
                            renderString += 'w';
                        }

                        if ((LightDiffuse >= 53) & (LightDiffuse < 54))
                        {
                            renderString += 'q';
                        }

                        if ((LightDiffuse >= 54) & (LightDiffuse < 55))
                        {
                            renderString += 'p';
                        }

                        if ((LightDiffuse >= 55) & (LightDiffuse < 56))
                        {
                            renderString += 'd';
                        }

                        if ((LightDiffuse >= 56) & (LightDiffuse < 57))
                        {
                            renderString += 'b';
                        }

                        if ((LightDiffuse >= 57) & (LightDiffuse < 58))
                        {
                            renderString += 'k';
                        }

                        if ((LightDiffuse >= 58) & (LightDiffuse < 59))
                        {
                            renderString += 'h';
                        }

                        if ((LightDiffuse >= 59) & (LightDiffuse < 60))
                        {
                            renderString += 'a';
                        }

                        if ((LightDiffuse >= 60) & (LightDiffuse < 61))
                        {
                            renderString += 'o';
                        }

                        if ((LightDiffuse >= 61) & (LightDiffuse < 62))
                        {
                            renderString += '*';
                        }

                        if ((LightDiffuse >= 62) & (LightDiffuse < 63))
                        {
                            renderString += '#';
                        }

                        if ((LightDiffuse >= 63) & (LightDiffuse < 64))
                        {
                            renderString += 'M';
                        }

                        if ((LightDiffuse >= 64) & (LightDiffuse < 65))
                        {
                            renderString += 'W';
                        }

                        if ((LightDiffuse >= 65) & (LightDiffuse < 66))
                        {
                            renderString += '&';
                        }

                        if ((LightDiffuse >= 66) & (LightDiffuse < 67))
                        {
                            renderString += '8';
                        }

                        if ((LightDiffuse >= 67) & (LightDiffuse < 68))
                        {
                            renderString += '%';
                        }

                        if ((LightDiffuse >= 68) & (LightDiffuse < 69))
                        {
                            renderString += 'B';
                        }

                        if ((LightDiffuse >= 69) & (LightDiffuse < 70))
                        {
                            renderString += '@';
                        }

                        if (LightDiffuse >= 70)
                        {
                            renderString += '$';
                        }
                    }
                }
                if (y > (-Grid.Height / 2) + 1)
                {
                    renderString += '\n';
                }
            }
            Console.ForegroundColor = ConsoleColor.White;

            FastConsole.Write(renderString);
        }

        public static double RayMarch(Vector3D camera, Vector3D rayDirection)
        {
            double distanceFromStart = 0;
            for (int i = 0; i < maxSteps; i++)
            {
                Vector3D point = Vector3D.Add(camera, Vector3D.Multiply(rayDirection, distanceFromStart));
                double distanceToScene = GetClosestDistance(point);
                distanceFromStart += distanceToScene;
                if ((distanceFromStart > maxDistance) || (distanceToScene < minDistance))
                {
                    break;
                }
            }
            return distanceFromStart;
        }
        public static Vector3D GetNormal(Vector3D point)
        {
            double d = GetClosestDistance(point);
            Vector3D Normal = Vector3D.Subtract(new Vector3D(d, d, d), new Vector3D(
                GetClosestDistance(Vector3D.Subtract(point, NormalX)),
                GetClosestDistance(Vector3D.Subtract(point, NormalY)),
                GetClosestDistance(Vector3D.Subtract(point, NormalZ))));
            return Vector3D.Normalize(Normal);

        }
        public static double GetLight(Vector3D point)
        {
            Vector3D lightPosition = new Vector3D(LightX, LightY, LightZ);
            Vector3D lightVector = Vector3D.Normalize(Vector3D.Subtract(lightPosition, point));
            Vector3D normal = GetNormal(point);

            double difuse = Vector3D.DotProduct(normal, lightVector);
            double d = RayMarch(Vector3D.Add(point, Vector3D.Multiply(normal, minDistance * 10)), lightVector);
            if (d < Vector3D.Length(Vector3D.Subtract(lightPosition, point)))
            {
                difuse *= 0.1;
            }

            return difuse;
        }
        public static double GetClosestDistance(Vector3D point)
        {

            Sphere4D sphere = new Sphere4D(
            SphereX + Math.Sin(counter) * SphereAnimX,
            SphereY + Math.Sin(counter) * SphereAnimY,
            SphereZ + Math.Cos(counter) * SphereAnimZ,
            SphereR + Math.Sin(counter) * SphereAnimR);

            double distanceToSphere = Vector3D.Length(Vector3D.Subtract(point, sphere.Position())) - sphere.Radius;
            double distancetoPlain = point.Y;
            double closestDistance;
            if (invertRender)
            {
                closestDistance = Math.Max(distancetoPlain, distanceToSphere);
            }
            else
            {
                closestDistance = Math.Min(distancetoPlain, distanceToSphere);
            }
            return closestDistance;
        }
    }
    public struct Sphere4D
    {
        public Sphere4D(double x, double y, double z, double radius)
        {
            X = x;
            Y = y;
            Z = z;
            Radius = radius;

        }
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public double Radius { get; }

        public Vector3D Position()
        {
            Vector3D position = new Vector3D(X, Y, Z);
            return position;
        }

    }

}
