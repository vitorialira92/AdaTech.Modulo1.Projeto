using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForcaLib
{
    internal static class Palavras
    {

        private static string[,] geographyDatabase = {

            { "Montanha mais alta do mundo", "EVEREST" },
            { "Rio mais longo da América do Sul", "AMAZONAS" },
            { "Deserto famoso na África", "SAARA" },
            { "Cidade mais populosa do Brasil", "SAO PAULO" },
            { "Maior oceano do mundo", "PACIFICO" },
            { "Grupo de ilhas conhecidas por sua biodiversidade", "GALAPAGOS" },
            { "Famoso canal que conecta o Atlântico ao Pacífico", "PANAMA" },
            { "Cidade conhecida como a capital da moda", "MILAO" },
            { "País conhecido pelos seus relógios e chocolates", "SUIÇA" },
            { "Cidade santuário do Império Inca", "MACHU PICCHU" },
            { "Península conhecida por conflitos geopolíticos", "CRIMEIA" },
            { "Capital da Inglaterra", "LONDRES" },
            { "País com a maior reserva de petróleo comprovada", "VENEZUELA" },
            { "Cordilheira que se estende pela costa oeste da América do Sul", "ANDES" },
            { "País insular conhecido por sua barreira de coral", "AUSTRALIA" },
            { "Cidade antiga preservada pela erupção do Monte Vesúvio", "POMPEIA" },
            { "Maior lago de água doce do mundo por volume", "BAIKAL" },
            { "Capital da Rússia", "MOSCOU" },
            { "Local do encontro das águas dos rios Negro e Solimões", "AMAZONIA" },
            { "País conhecido como a terra do sol nascente", "JAPAO" },
            { "Estreito que separa a Ásia da Europa", "BOSFORO" },
            { "Cachoeira mais alta do mundo", "ANGEL" },
            { "Maior deserto da Austrália", "SIMPSON" },
            { "Arquipélago dividido entre a Malásia, Indonésia e Brunei", "BORNEO" },
            { "Deserto localizado nos EUA famoso por suas formações rochosas", "MOJAVE" }
        };

        private static string[,] companiesDatabase =
        {
            { "Gigante de tecnologia fundada por Bill Gates", "MICROSOFT" },
            { "Maior empresa de comércio eletrônico do mundo", "AMAZON" },
            { "Fabricante de carros elétricos liderada por Elon Musk", "TESLA" },
            { "Rede social com um pássaro azul no logo", "TWITTER" },
            { "Empresa pioneira em computadores pessoais", "APPLE" },
            { "Gigante dos refrigerantes conhecida pela cor vermelha", "COCA-COLA" },
            { "Maior rede de fast food do mundo", "MCDONALDS" },
            { "Empresa de streaming de vídeo popular", "NETFLIX" },
            { "Maior companhia aérea da Europa", "RYANAIR" },
            { "Famosa marca de café com uma sereia no logo", "STARBUCKS" },
            { "Gigante coreana de eletrônicos", "SAMSUNG" },
            { "Famosa marca de roupas esportivas com um 'swoosh'", "NIKE" },
            { "Empresa de tecnologia conhecida por seus sistemas de busca", "GOOGLE" },
            { "Empresa de videogames japonesa, criadora do Mario", "NINTENDO" },
            { "Gigante dos cosméticos francesa", "LOREAL" },
            { "Fabricante alemã de automóveis de luxo", "MERCEDES-BENZ" },
            { "Fabricante sueca de móveis e decoração", "IKEA" },
            { "Gigante do petróleo britânica", "BP" },
            { "Empresa de tecnologia famosa por seus serviços na nuvem", "ORACLE" },
            { "Maior banco da América Latina", "ITAU" },
            { "Gigante chinesa de comércio eletrônico", "ALIBABA" },
            { "Rede de hotéis fundada por Conrad Hilton", "HILTON" },
            { "Grande fabricante de brinquedos dinamarquesa", "LEGO" },
            { "Gigante da aviação dos Estados Unidos", "BOEING" },
            { "Fabricante de chocolates suíços", "LINDT" }
        };

        private static string[,] worldHistoryDatabase =
        {
            { "Grande muralha construída na China antiga", "MURALHA DA CHINA" },
            { "Guerra entre Esparta e Atenas na Grécia Antiga", "GUERRA DO PELOPONESO" },
            { "Invasor mongol do século XIII", "GENGIS KHAN" },
            { "Cidade antiga destruída por um vulcão", "POMPEIA" },
            { "Famoso faraó do Egito Antigo", "TUTANCAMON" },
            { "Pintor da Mona Lisa", "LEONARDO DA VINCI" },
            { "Primeiro presidente dos Estados Unidos", "GEORGE WASHINGTON" },
            { "Revolução que ocorreu na França no final do século XVIII", "REVOLUÇAO FRANCESA" },
            { "Império liderado por César Augusto", "ROMANO" },
            { "Pandemia que devastou a Europa na Idade Média", "PESTE NEGRA" },
            { "Símbolo da liberdade dos EUA, presente da França", "ESTATUA DA LIBERDADE" },
            { "Movimento de reforma religiosa do século XVI", "REFORMA PROTESTANTE" },
            { "Descobridor da América em 1492", "CRISTOVAO COLOMBO" },
            { "Líder da independência da Índia", "MAHATMA GANDHI" },
            { "Conflito global entre 1939 e 1945", "SEGUNDA GUERRA MUNDIAL" },
            { "Rainha britânica do século XIX", "VITORIA" },
            { "Cidade-estado grega conhecida por sua democracia", "ATENAS" },
            { "Muro que dividiu uma capital europeia durante a Guerra Fria", "MURO DE BERLIM" },
            { "Imperador francês exilado em Santa Helena", "NAPOLEAO" },
            { "Primeira civilização mesopotâmica", "SUMERIA" },
            { "Conflito armado entre o Norte e o Sul dos EUA", "GUERRA CIVIL AMERICANA" },
            { "Grande explorador veneziano do Oriente", "MARCO POLO" },
            { "Imperatriz russa do século XVIII", "CATARINA, A GRANDE" },
            { "Batalha decisiva das Guerras Napoleônicas", "WATERLOO" },
            { "Movimento de independência das colônias americanas", "REVOLUÇAO AMERICANA" }
        };

        private static string[,] entertainmentDatabase =
         {
            { "Série de filmes sobre bruxaria de J.K. Rowling", "HARRY POTTER" },
            { "Cidade americana conhecida como a capital mundial do cinema", "HOLLYWOOD" },
            { "Famoso festival de música em Woodstock", "WOODSTOCK" },
            { "Conhecido jogo de blocos da Mojang", "MINECRAFT" },
            { "Cantor de 'Thriller'", "MICHAEL JACKSON" },
            { "Festival brasileiro de música e entretenimento", "ROCK IN RIO" },
            { "Popular série de TV sobre zumbis", "THE WALKING DEAD" },
            { "Ícone do pop conhecida como 'Material Girl'", "MADONNA" },
            { "Banda britânica de 'Yellow Submarine'", "THE BEATLES" },
            { "Famoso parque temático na Califórnia e Flórida", "DISNEYLAND" },
            { "Série de filmes estrelados por Vin Diesel, com foco em carros", "VELOZES E FURIOSOS" },
            { "Cantor e compositor britânico de 'Shape of You'", "ED SHEERAN" },
            { "Maior prêmio do cinema americano", "OSCAR" },
            { "Plataforma de streaming de vídeo", "NETFLIX" },
            { "Festival de música e arte na Califórnia", "COACHELLA" },
            { "Famoso cantor de 'Rocket Man'", "ELTON JOHN" },
            { "Série de TV sobre um professor de química que vira traficante", "BREAKING BAD" },
            { "Popular jogo de sobrevivência e construção", "FORTNITE" },
            { "Conhecida boy band de 'I Want It That Way'", "BACKSTREET BOYS" },
            { "Filme de grande sucesso sobre o naufrágio do RMS Titanic", "TITANIC" },
            { "Conhecida série de fantasia da HBO", "GAME OF THRONES" },
            { "Clássico do cinema de terror, dirigido por Alfred Hitchcock", "PSICOSE" },
            { "Cantora de 'Like a Virgin'", "MADONNA" },
            { "Famoso filme de super-heróis da Marvel", "VINGADORES" },
            { "Conhecido autor de 'O Senhor dos Anéis'", "J.R.R. TOLKIEN" }
        };

        private static string[,] taylorSwiftDatabase =
        {
            { "Primeiro álbum de Taylor Swift", "TAYLOR SWIFT" },
            { "Álbum com o hit 'Love Story'", "FEARLESS" },
            { "Música famosa sobre um ex-namorado chamado Jake", "ALL TOO WELL" },
            { "Álbum de 2012 de Taylor Swift", "RED" },
            { "Prêmio de Artista do Ano no AMA de 2009", "AMERICAN MUSIC AWARD" },
            { "Gênero musical dos primeiros álbuns de Taylor", "COUNTRY" },
            { "Música com tema de conto de fadas", "LOVE STORY" },
            { "Primeira música de Taylor a alcançar a Billboard Hot 100", "TIM MCGRAW" },
            { "Filme em que Taylor apareceu com Taylor Lautner", "VALENTINES DAY" },
            { "Turnê mundial de 2011 de Taylor Swift", "SPEAK NOW TOUR" },
            { "Cantor com quem Taylor fez dueto em 'Everything Has Changed'", "ED SHEERAN" },
            { "Música sobre a mãe de Taylor", "THE BEST DAY" },
            { "Álbum surpresa de 2020", "FOLKLORE" },
            { "Música de Taylor Swift com Brendon Urie", "ME" },
            { "Álbum com 'Cardigan' e 'August'", "FOLKLORE" },
            { "Segundo álbum surpresa de 2020", "EVERMORE" },
            { "Gato de Taylor Swift chamado após personagem de 'Law & Order'", "OLIVIA BENSON" },
            { "Cidade natal de Taylor Swift", "READING" },
            { "Música de Taylor sobre Harry Styles", "STYLE" },
            { "Documentário de Taylor Swift na Netflix", "MISS AMERICANA" },
            { "Álbum de Taylor de 2010", "SPEAK NOW" },
            { "Nome completo de Taylor Swift", "TAYLOR ALISON SWIFT" },
            { "Álbum de Taylor com 'Willow'", "EVERMORE" },
            { "Turnê de Taylor em 2018", "REPUTATION TOUR" },
            { "Colaboração de Taylor Swift com Zayn", "I DONT WANNA LIVE FOREVER" },
            { "Álbum regravado de 2021", "FEARLESS TAYLORS VERSION" },
            { "Canção de Taylor sobre seu lar", "MEAN" },
            { "Música de vingança contra Kanye West", "LOOK WHAT YOU MADE ME DO" },
            { "Música sobre crescer em uma cidade pequena", "FIFTEEN" },
            { "Álbum que inclui 'You Belong With Me'", "FEARLESS" },
            { "Música com tema circense", "WONDERLAND" },
            { "Primeira música de Taylor a vencer o Grammy", "WHITE HORSE" },
            { "Álbum visual de Taylor Swift no Disney+", "FOLKLORE THE LONG POND STUDIO SESSIONS" },
            { "Música sobre um amor de verão", "AUGUST" },
            { "Álbum que marca o retorno ao country", "RED TAYLORS VERSION" },
            { "Hit de Taylor com Kendrick Lamar", "BAD BLOOD" },
            { "Música dedicada a Calvin Harris", "DELICATE" },
            { "Gato escocês de Taylor Swift", "MEREDITH GREY" }
        };


        public static string[,] GetGeographyWord()
        {
            int index = GetRandomNumber(geographyDatabase.GetLength(0));

            string[,] chosenWord = new string[1, 2];

            chosenWord[0, 0] = geographyDatabase[index, 0];
            chosenWord[0, 1] = geographyDatabase[index, 1];

            return chosenWord;
        }

        public static string[,] GetCompaniesWord()
        {
            int index = GetRandomNumber(companiesDatabase.GetLength(0));

            string[,] chosenWord = new string[1, 2];

            chosenWord[0, 0] = companiesDatabase[index, 0];
            chosenWord[0, 1] = companiesDatabase[index, 1];

            return chosenWord;
        }

        public static string[,] GetWorldHistoryWord()
        {
            int index = GetRandomNumber(worldHistoryDatabase.GetLength(0));

            string[,] chosenWord = new string[1, 2];

            chosenWord[0, 0] = worldHistoryDatabase[index, 0];
            chosenWord[0, 1] = worldHistoryDatabase[index, 1];

            return chosenWord;
        }

        public static string[,] GetEntertainmentWord()
        {
            int index = GetRandomNumber(entertainmentDatabase.GetLength(0));

            string[,] chosenWord = new string[1, 2];

            chosenWord[0, 0] = entertainmentDatabase[index, 0];
            chosenWord[0, 1] = entertainmentDatabase[index, 1];

            return chosenWord;
        }

        public static string[,] GetTaylorSwiftWord()
        {
            int index = GetRandomNumber(taylorSwiftDatabase.GetLength(0));

            string[,] chosenWord = new string[1, 2];

            chosenWord[0, 0] = taylorSwiftDatabase[index, 0];
            chosenWord[0, 1] = taylorSwiftDatabase[index, 1];

            return chosenWord;
        }


        private static int GetRandomNumber(int limit)
        {
            Random random = new Random();
            return random.Next(0, limit);
        }
    }
}
