using CopilotSmartEncodingClone;
using System.Collections.Generic;
using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Start");

            string b = SmartEncoding.NormalizeText(@"*** Actualización de PCSD Chat *** Estimados padres, los mensajes de emergencia se envían por correo electrónico ya que es más rápido, y un texto de seguimiento como este enviado más tarde. El informe de la policía está a continuación: http://go.atlasrtx.com/rd?eid=74246&a=ctac ¡Texto aquí con preguntas!
Park City Police Department responded at 9:30 a.m.today(Nov. 14) to a suspicious incident involving a man brandishing a handgun in the field between Park City High School and McPolin Elementary School.A high school student spotted the individual and immediately alerted school authorities.
The police located the individual at the 1700 block of Kearns Boulevard. Police identified and detained the individual at 10:09 a.m.Appropriate charges are being screened through the City Attorney’s Office.
The lockout at all schools was lifted by police at 10:12 a.m.All schools are back to normal operation.
Police remind parents to follow district protocol and stay away from the schools until law enforcement deems the area safe. Park City Police and district officials thank the student who utilized the “see something, say something” protocol to report suspicious activity to officials.
The Park City Police were assisted by the Summit County Sheriff’s Office and Utah Highway Patrol.
Parents are asked to review the PCSD Emergency Procedures with their students tonight(see below)
Joint statement from Park City Police and District on today’s incidentDistrict on today’s incident");
            Console.WriteLine(b);




            Console.ReadLine();
            Console.ReadLine();



            //Encoding gsmEnc = new Mediaburst.Text.GSMEncoding();
            //Encoding utf8Enc = new System.Text.UTF8Encoding();

            //byte[] gsmBytes = utf8Enc.GetBytes(body);
            //byte[] utf8Bytes = Encoding.Convert(gsmEnc, utf8Enc, gsmBytes);
            //body = utf8Enc.GetString(utf8Bytes);

            //Console.WriteLine(body);
            //Console.ReadLine();



        }
    }
}
