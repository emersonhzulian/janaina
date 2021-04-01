using System;

namespace jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int jogador= 1; 
            string posicao;
            string a=" ";
            string b=" "; 
            string c=" ";
            string d=" ";
            string e=" ";
            string f=" ";
            string g=" ";
            string h=" ";
            string i=" "; 
            bool jogou= false;
            bool ganhou= false;
            while(true)
            {  
                jogou=false; 
                EscreveJogoDaVelhaNaTela(a,b,c,d,e,f,g,h,i);
                
                if(ganhou)
                { 
                    Console.WriteLine("voce ganhou");
                    break;
                }
                else
                { 
            
                    if(a!=" "&& b!=" "&& c!=" "&& d!=" "&& e!=" "&& f!=" "&& g!=" "&& h!=" "&& i!=" ")
                    {
                        Console.WriteLine("empatou");
                        break;
                    }
                }
                Console.WriteLine("qual sua posicao");
                        
                posicao=Console.ReadLine();
                
                
                if(posicao=="a" && a==" ")
                {
                    jogou= true;
                    if(jogador == 1)
                    {
                        
                        a="x";
                    }
                    else
                    {  
                        
                        a="o";
                    }
                    
                }
                else
                {
                    if(posicao == "b" && b==" ")
                    {
                        jogou= true;
                        if(jogador == 1)
                        {
                            b="x";
                        }
                        else
                        {
                            b="o";
                        }
                    } 
                    else
                    {
                        if(posicao == "c"&& c==" ")
                        {
                            jogou= true;
                            if(jogador == 1)
                            {
                                c="x";
                            }
                            else
                            {
                                c="o";
                            }
                        }
                        else
                        {
                            if(posicao == "d" && d==" ")
                            {
                                jogou= true;
                                if(jogador == 1)
                                {
                                    d="x";
                                }
                                else
                                {
                                    d="o";
                                }
                            } 
                            else
                            {
                                if(posicao == "e"&& e==" ")
                                {
                                    jogou= true;
                                    if(jogador == 1)
                                    {
                                        e="x";
                                    }
                                    else
                                    {
                                        e="o";
                                    }
                                } else
                                {
                                    if(posicao == "f"&& f==" ")
                                    {
                                        jogou= true;
                                        if(jogador == 1)
                                        {
                                            f="x";
                                        }
                                        else
                                        {
                                            f="o";
                                        }
                                    } else
                                    {
                                        if(posicao == "g"&& g==" ")
                                        {
                                            jogou= true;
                                            if(jogador == 1)
                                            {
                                                g="x";
                                            }
                                            else
                                            {
                                                g="o";
                                            }
                                        } else
                                        {
                                            if(posicao == "h"&& h==" ")
                                            {
                                                jogou= true;
                                                if(jogador == 1)
                                                {
                                                    h="x";
                                                }
                                                else
                                                {
                                                    h="o";
                                                }
                                            } 
                                            else
                                            {
                                                if(posicao == "i"&& i==" ")
                                                {
                                                    jogou= true;
                                                    if(jogador == 1)
                                                    {
                                                        i="x";
                                                    }
                                                    else
                                                    {
                                                        i="o";
                                                    }
                                                } 
                                            }
                                        }
                                    }
                                }

                            }
                        }

                    }
                }
            
                if(jogou)
                {
                    if(jogador==1)    
                    {
                        jogador=2;                
                    }
                    else
                    {
                        jogador=1;
                    }
                }        
                

                if((a==b && b==c) && (a != " " && b != " " && c != " "))
                {
                    ganhou= true;
                } 

                if((d==e && e==f) && (d != " " && e != " " && f != " "))
                {
                    ganhou= true;
                }
                if((g==h && h==i) && (g != " " && h != " " && i != " "))
                {
                    ganhou= true;
                }
                if((a==d && d==g) && (a != " " && d != " " && g != " "))
                {
                    ganhou= true;
                }
                if((b==e && e==h) && (b != " " && e != " " && h != " "))
                {
                    ganhou= true;
                }
                if((c==f && f==i) && (c != " " && f != " " && i != " "))
                {
                    ganhou= true;
                }
                if((a==e&& e==i) && (a != " " && e != " " && i != " "))
                {
                     ganhou= true;
                }
                if((c==e && e==g) && (c != " " && e != " " && g!= " "))
                {
                    ganhou= true;
                }

            }    
            Console.ReadLine(); 

        }

        private static void EscreveJogoDaVelhaNaTela(string a, string b, string c, string d, string e, string f, string g,string h, string i)
        {
            Console.Clear(); //apaga
            Console.WriteLine(a +"|"+b+"|"+c);
            Console.WriteLine("--------------");
            Console.WriteLine(d+"|"+e+"|"+f);
            Console.WriteLine ("-------------");
            Console.WriteLine(g+"|"+h+"|"+i);
        }


    private static bool verificaSeGanhou (string a, string b, string c)
    {
        return false;
    }

    }
}
