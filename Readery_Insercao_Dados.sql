USE Readery

INSERT INTO Editora (NomeEditora)
VALUES
('Companhia das Letras'),
('Editora Record'),
('Galera Record'),
('Rocco'),
('Intrínseca'),
('Editora Arqueiro'),
('Sextante'),
('Aleph'),
('BestSeller'),
('HarperCollins Brasil'),
('Objetiva'),
('Zahar'),
('Seguinte'),
('Globo Livros'),
('Principis');

INSERT INTO Livro (Titulo, Sinopse, ISBN, NumPaginas, CapaURL, EditoraID) VALUES 
('Dom Casmurro', 'O romance mais famoso de Machado de Assis, narrado por Bento Santiago, que conta a história de seu amor por Capitu e a dúvida obsessiva sobre a traição dela.', '978-857-23269-7', 300, 'https://bibliotecavirtual.com/capas/dom_casmurro.jpg', 15), 
('Capitães da Areia', 'A história de um grupo de menores abandonados que vivem em um trapiche abandonado em Salvador, liderados pelo carismático Pedro Bala.', '978-853-59008-7', 368, 'https://bibliotecavirtual.com/capas/capitaes_areia.jpg', 1), 
('Vidas Secas', 'Um retrato pungente da vida no sertão nordestino, focado na luta da família de Fabiano para sobreviver à seca e à miséria.', '978-850-81544-2', 176, 'https://bibliotecavirtual.com/capas/vidas_secas.jpg', 1), 
('O Alquimista', 'Um jovem pastor, Santiago, viaja da Espanha ao Egito em busca de um tesouro enterrado. Uma fábula sobre seguir a "Lenda Pessoal".', '978-852-02051-1', 208, 'https://bibliotecavirtual.com/capas/o_alquimista.jpg', 7), 
('1984', 'Um romance distópico que narra a vida de Winston Smith em um regime totalitário onde o Grande Irmão vigia a todos, e o pensamento individual é crime.', '978-853-59148-9', 416, 'https://bibliotecavirtual.com/capas/1984.jpg', 1), 
('Cem Anos de Solidão', 'A saga da família Buendía ao longo de sete gerações na cidade fictícia de Macondo. Uma obra-prima do realismo mágico.', '978-853-59106-2', 432, 'https://bibliotecavirtual.com/capas/cem_anos_solidao.jpg', 2), 
('O Pequeno Príncipe', 'Uma fábula poética sobre a amizade, o amor, a perda e o sentido da vida, contada através dos olhos de um garoto de outro planeta.', '978-857-40678-9', 96, 'https://bibliotecavirtual.com/capas/pequeno_principe.jpg', 12), 
('Orgulho e Preconceito', 'Um romance de Jane Austen que acompanha a protagonista Elizabeth Bennet e sua relação turbulenta e cheia de mal-entendidos com o Mr. Darcy.', '978-858-07705-0', 448, 'https://bibliotecavirtual.com/capas/orgulho_preconceito.jpg', 15), 
('Crime e Castigo', 'O estudante Raskólnikov comete um assassinato e lida com as consequências morais e psicológicas de seu ato em São Petersburgo.', '978-857-32651-6', 560, 'https://bibliotecavirtual.com/capas/crime_castigo.jpg', 12), 
('As Aventuras de Sherlock Holmes', 'Coleção de contos do icônico detetive Sherlock Holmes e seu fiel companheiro, Dr. Watson, em busca da solução de mistérios em Londres.', '978-857-82715-8', 320, 'https://bibliotecavirtual.com/capas/sherlock_holmes.jpg', 15), 
('É Assim Que Acaba', 'Lily Bloom se muda para Boston, abre uma floricultura e se apaixona por um neurocirurgião, mas a sombra de seu passado e um novo amor a confrontam.', '978-850-11120-1', 368, 'https://bibliotecavirtual.com/capas/e_assim_que_acaba.jpg', 3), 
('Verity', 'Lowen Ashleigh, uma escritora falida, é contratada para terminar a série de livros de Verity Crawford, uma autora de sucesso acidentada, e descobre um manuscrito perturbador.', '978-850-11175-3', 320, 'https://bibliotecavirtual.com/capas/verity.jpg', 3), 
('A Biblioteca da Meia-Noite', 'Nora Seed tem a chance de ver como sua vida teria sido se tivesse feito escolhas diferentes, em uma biblioteca que fica entre a vida e a morte.', '978-850-11185-8', 320, 'https://bibliotecavirtual.com/capas/biblioteca_meia_noite.jpg', 5), 
('Os Sete Maridos de Evelyn Hugo', 'Uma lenda de Hollywood, Evelyn Hugo, decide contar a história de sua vida glamourosa e escandalosa, e de seus sete casamentos, a uma jornalista desconhecida.', '978-850-11191-9', 368, 'https://bibliotecavirtual.com/capas/evelyn_hugo.jpg', 5), 
('Tudo É Rio', 'Um romance intenso e lírico sobre amor, dor, obsessão e o ciclo da vida, contado a partir das tragédias de um casal.', '978-859-28822-4', 210, 'https://bibliotecavirtual.com/capas/tudo_e_rio.jpg', 2), 
('Harry Potter e a Pedra Filosofal', 'O primeiro livro da saga. O jovem órfão Harry Potter descobre que é um bruxo famoso e é convidado a estudar na Escola de Magia e Bruxaria de Hogwarts.', '978-853-25202-7', 224, 'https://bibliotecavirtual.com/capas/hp_pedra_filosofal.jpg', 4), 
('A Paciente Silenciosa', 'Uma psicoterapeuta e seu paciente, que cometeu um assassinato e parou de falar, envolvem-se em um mistério que testa os limites da mente humana.', '978-853-25310-2', 336, 'https://bibliotecavirtual.com/capas/paciente_silenciosa.jpg', 5), 
('Sapiens: Uma Breve História da Humanidade', 'Uma investigação sobre a história humana, desde as origens da espécie até as revoluções cognitiva, agrícola e científica.', '978-852-02015-7', 464, 'https://bibliotecavirtual.com/capas/sapiens.jpg', 11), 
('O Poder do Hábito', 'Explora a ciência por trás de como os hábitos se formam, como eles podem ser mudados e como impactam nossas vidas, carreiras e organizações.', '978-853-59214-1', 408, 'https://bibliotecavirtual.com/capas/poder_habito.jpg', 1), 
('Mindset: A Nova Psicologia do Sucesso', 'A Dra. Carol S. Dweck apresenta a diferença entre a mentalidade fixa e a mentalidade de crescimento e como a última pode levar ao sucesso.', '978-853-95092-5', 304, 'https://bibliotecavirtual.com/capas/mindset.jpg', 9), 
('Como Fazer Amigos e Influenciar Pessoas', 'Um clássico de autoajuda que oferece conselhos práticos sobre relações interpessoais, comunicação e como se tornar uma pessoa influente.', '978-850-40131-2', 288, 'https://bibliotecavirtual.com/capas/como_fazer_amigos.jpg', 14), 
('Pai Rico, Pai Pobre', 'Um livro de finanças pessoais que ensina a importância da educação financeira, independência e construção de ativos.', '978-858-00403-7', 336, 'https://bibliotecavirtual.com/capas/pai_rico_pai_pobre.jpg', 7), 
('Uma Breve História do Tempo', 'Stephen Hawking explica conceitos de cosmologia, como buracos negros, singularidades e a natureza do tempo, de forma acessível.', '978-857-82706-9', 256, 'https://bibliotecavirtual.com/capas/historia_tempo.jpg', 2), 
('A Culpa É das Estrelas', 'Dois adolescentes, Hazel e Gus, que se conhecem em um grupo de apoio a pacientes com câncer, se apaixonam e embarcam em uma jornada comovente.', '978-858-05734-8', 288, 'https://bibliotecavirtual.com/capas/culpa_estrelas.jpg', 13), 
('Extraordinário', 'August Pullman, um menino com deformidade facial, enfrenta o desafio de frequentar a escola regular pela primeira vez.', '978-853-25296-9', 320, 'https://bibliotecavirtual.com/capas/extraordinario.jpg', 5), 
('A Menina Que Roubava Livros', 'Narrado pela Morte, conta a história de Liesel Meminger, uma garota na Alemanha nazista que encontra conforto roubando livros.', '978-857-82706-1', 480, 'https://bibliotecavirtual.com/capas/menina_roubava_livros.jpg', 5), 
('O Nome do Vento', 'Kvothe, um herói lendário, conta a um cronista a verdadeira história de sua vida: desde a infância em uma trupe de artistas até se tornar um temido mago.', '978-859-92964-8', 656, 'https://bibliotecavirtual.com/capas/nome_do_vento.jpg', 8), 
('Código Da Vinci', 'O simbologista Robert Langdon se envolve em uma conspiração internacional após um assassinato no Museu do Louvre, que o leva a desvendar segredos da história cristã.', '978-853-59051-9', 448, 'https://bibliotecavirtual.com/capas/codigo_da_vinci.jpg', 6), 
('Fahrenheit 451', 'Em uma sociedade futurista onde livros são proibidos e queimados, o bombeiro Guy Montag começa a questionar a censura e o vazio de sua vida.', '978-853-59005-7', 208, 'https://bibliotecavirtual.com/capas/fahrenheit_451.jpg', 1), 
('A Revolução dos Bichos', 'Uma alegoria política onde os animais de uma fazenda se rebelam contra os humanos, mas acabam criando uma nova tirania sob a liderança dos porcos.', '978-853-59118-5', 160, 'https://bibliotecavirtual.com/capas/revolucao_bichos.jpg', 1);


--ADICIONANDO COM PROCEDURES
EXEC adicionarLivro @Titulo = 'Um Conto de Duas Cidades', @Sinopse = 'Um romance histórico ambientado em Londres e Paris durante a Revolução Francesa, focado em temas de sacrifício e redenção.', @ISBN = '978-857-799195-4', @NumPaginas = 416, @CapaURL = 'https://bibliotecavirtual.com/capas/conto_duas_cidades.jpg', @EditoraId = 15;
EXEC adicionarLivro @Titulo = 'Mistborn: O Império Final', @Sinopse = 'Kelsier, um ladrão talentoso, recruta uma equipe para derrubar um império que oprime a humanidade há mil anos, usando poderes de Alomancia.', @ISBN = '978-857-686525-4', @NumPaginas = 640, @CapaURL = 'https://bibliotecavirtual.com/capas/imperio_final.jpg', @EditoraId = 8;
EXEC adicionarLivro @Titulo = 'O Castelo Animado', @Sinopse = 'Sophie é amaldiçoada com a forma de uma velha e busca a cura no castelo mágico e ambulante do enigmático mago Howl.', @ISBN = '978-857-827827-7', @NumPaginas = 336, @CapaURL = 'https://bibliotecavirtual.com/capas/castelo_animado.jpg', @EditoraId = 5;
EXEC adicionarLivro @Titulo = 'A Coroa de Midnight (Trono de Vidro #2)', @Sinopse = 'Celaena Sardothien deve se equilibrar entre sua lealdade à coroa e sua luta contra as forças obscuras que ameaçam Erilea.', @ISBN = '978-850-140138-0', @NumPaginas = 384, @CapaURL = 'https://bibliotecavirtual.com/capas/coroa_midnight.jpg', @EditoraId = 3;
EXEC adicionarLivro @Titulo = 'Garota Exemplar', @Sinopse = 'No aniversário de cinco anos de casamento, a esposa de Nick desaparece, e ele se torna o principal suspeito no jogo de gato e rato.', @ISBN = '978-853-252870-5', @NumPaginas = 480, @CapaURL = 'https://bibliotecavirtual.com/capas/garota_exemplar.jpg', @EditoraId = 5;
EXEC adicionarLivro @Titulo = 'Assassinato no Expresso do Oriente', @Sinopse = 'O famoso detetive Hercule Poirot investiga um assassinato a bordo do luxuoso trem, descobrindo que todos os passageiros são suspeitos.', @ISBN = '978-852-543160-5', @NumPaginas = 256, @CapaURL = 'https://bibliotecavirtual.com/capas/expresso_oriente.jpg', @EditoraId = 1;
EXEC adicionarLivro @Titulo = 'A Garota no Trem', @Sinopse = 'Rachel, uma alcoólatra, testemunha algo perturbador em uma casa que ela observa diariamente de seu trem, e se envolve em uma investigação.', @ISBN = '978-855-100067-1', @NumPaginas = 376, @CapaURL = 'https://bibliotecavirtual.com/capas/garota_trem.jpg', @EditoraId = 10;
EXEC adicionarLivro @Titulo = 'O Silêncio dos Inocentes', @Sinopse = 'Uma jovem estagiária do FBI é designada a entrevistar o brilhante, mas perigoso, Dr. Hannibal Lecter para ajudar a capturar um serial killer.', @ISBN = '978-857-799401-4', @NumPaginas = 368, @CapaURL = 'https://bibliotecavirtual.com/capas/silencio_inocentes.jpg', @EditoraId = 15;
EXEC adicionarLivro @Titulo = 'O Segredo', @Sinopse = 'Livro baseado na lei da atração, ensinando como o poder do pensamento positivo e visualização pode mudar a vida das pessoas.', @ISBN = '978-859-929501-7', @NumPaginas = 216, @CapaURL = 'https://bibliotecavirtual.com/capas/o_segredo.jpg', @EditoraId = 7;
EXEC adicionarLivro @Titulo = 'Hábitos Atômicos', @Sinopse = 'Um guia prático e comprovado para criar bons hábitos e se livrar dos maus hábitos em pequenos passos, usando a regra dos 4 passos.', @ISBN = '978-854-700057-0', @NumPaginas = 320, @CapaURL = 'https://bibliotecavirtual.com/capas/habitos_atomicos.jpg', @EditoraId = 10;
EXEC adicionarLivro @Titulo = 'As Armas da Persuasão', @Sinopse = 'Robert Cialdini explica os 6 princípios psicológicos universais que influenciam as decisões humanas, desde vendas até política.', @ISBN = '978-857-542023-3', @NumPaginas = 320, @CapaURL = 'https://bibliotecavirtual.com/capas/armas_persuasao.jpg', @EditoraId = 9;
EXEC adicionarLivro @Titulo = 'Elon Musk: Como o CEO da SpaceX e Tesla está Moldando Nosso Futuro', @Sinopse = 'Uma biografia fascinante de Elon Musk, cobrindo sua infância, a criação de PayPal, SpaceX e Tesla, e sua visão para a colonização de Marte.', @ISBN = '978-858-057861-6', @NumPaginas = 416, @CapaURL = 'https://bibliotecavirtual.com/capas/elon_musk.jpg', @EditoraId = 5;
EXEC adicionarLivro @Titulo = 'Minimalismo Digital', @Sinopse = 'O autor Cal Newport propõe um modelo para usar a tecnologia de forma intencional e focar no que realmente é valioso na vida.', @ISBN = '978-855-081035-7', @NumPaginas = 304, @CapaURL = 'https://bibliotecavirtual.com/capas/minimalismo_digital.jpg', @EditoraId = 11;
EXEC adicionarLivro @Titulo = 'O Andar do Bêbado', @Sinopse = 'Uma exploração divertida e provocante sobre o papel do acaso em nossas vidas e por que nos esforçamos para ignorá-lo.', @ISBN = '978-853-591147-3', @NumPaginas = 368, @CapaURL = 'https://bibliotecavirtual.com/capas/andar_bebado.jpg', @EditoraId = 1;
EXEC adicionarLivro @Titulo = 'Memórias Póstumas de Brás Cubas', @Sinopse = 'Narrativa póstuma onde o defunto-autor Brás Cubas conta sua vida com sarcasmo e ceticismo, analisando a sociedade da época.', @ISBN = '978-858-077053-3', @NumPaginas = 304, @CapaURL = 'https://bibliotecavirtual.com/capas/memorias_postumas.jpg', @EditoraId = 15;
EXEC adicionarLivro @Titulo = 'Grande Sertão: Veredas', @Sinopse = 'O maior épico de Guimarães Rosa, narrado pelo jagunço Riobaldo, que reflete sobre o amor, o diabo e o sentido da vida no sertão de Minas Gerais.', @ISBN = '978-850-301235-5', @NumPaginas = 624, @CapaURL = 'https://bibliotecavirtual.com/capas/grande_sertao.jpg', @EditoraId = 1;
EXEC adicionarLivro @Titulo = 'Madame Bovary', @Sinopse = 'O romance de Gustave Flaubert sobre Emma Bovary, uma mulher frustrada com seu casamento e que busca o romance e a emoção em casos extraconjugais.', @ISBN = '978-857-799196-1', @NumPaginas = 400, @CapaURL = 'https://bibliotecavirtual.com/capas/madame_bovary.jpg', @EditoraId = 15;
EXEC adicionarLivro @Titulo = 'A Hora da Estrela', @Sinopse = 'O último romance de Clarice Lispector. Conta a trágica história de Macabéa, uma datilógrafa nordestina, e sua existência pobre no Rio de Janeiro.', @ISBN = '978-853-253073-9', @NumPaginas = 96, @CapaURL = 'https://bibliotecavirtual.com/capas/hora_estrela.jpg', @EditoraId = 2;
EXEC adicionarLivro @Titulo = 'A Cidade e As Serras', @Sinopse = 'Um romance do português Eça de Queirós, que contrasta a vida luxuosa e artificial da cidade com a vida simples e prazerosa do campo.', @ISBN = '978-858-271032-4', @NumPaginas = 280, @CapaURL = 'https://bibliotecavirtual.com/capas/cidade_serras.jpg', @EditoraId = 15;
EXEC adicionarLivro @Titulo = 'Kafka à Beira-Mar', @Sinopse = 'Kafka Tamura foge de casa em busca de sua mãe e irmã. Enquanto isso, um velho com habilidades especiais procura um gato desaparecido.', @ISBN = '978-857-962057-7', @NumPaginas = 584, @CapaURL = 'https://bibliotecavirtual.com/capas/kafka_beira_mar.jpg', @EditoraId = 1;
EXEC adicionarLivro @Titulo = 'As Crônicas de Nárnia: O Leão, a Feiticeira e o Guarda-Roupa', @Sinopse = 'Quatro irmãos encontram um mundo mágico além de um guarda-roupa, onde um leão sábio e uma feiticeira maligna lutam pelo controle.', @ISBN = '978-852-601332-6', @NumPaginas = 208, @CapaURL = 'https://bibliotecavirtual.com/capas/narnia_leao.jpg', @EditoraId = 10;
EXEC adicionarLivro @Titulo = 'Perdida (Série Perdida #1)', @Sinopse = 'Sofia, uma garota moderna e independente, é misteriosamente transportada para o século XIX e se apaixona por um cavalheiro.', @ISBN = '978-857-686259-8', @NumPaginas = 420, @CapaURL = 'https://bibliotecavirtual.com/capas/perdida.jpg', @EditoraId = 3;
EXEC adicionarLivro @Titulo = 'O Morro', @Sinopse = 'Um suspense psicológico focado em uma família que se muda para uma casa isolada e cheia de segredos na Colina dos Olhos.', @ISBN = '978-850-111956-7', @NumPaginas = 384, @CapaURL = 'https://bibliotecavirtual.com/capas/o_morro.jpg', @EditoraId = 2;
EXEC adicionarLivro @Titulo = 'A Garota Que Tinha Tudo', @Sinopse = 'Ani FaNelli, uma mulher que parece ter a vida perfeita, é forçada a confrontar um evento traumático de seu passado adolescente.', @ISBN = '978-850-111000-7', @NumPaginas = 400, @CapaURL = 'https://bibliotecavirtual.com/capas/garota_tinha_tudo.jpg', @EditoraId = 3;
EXEC adicionarLivro @Titulo = 'Quem é Você, Alasca?', @Sinopse = 'Miles Halter se matricula em um internato para buscar o "Grande Talvez" e se apaixona por Alasca Young, uma garota enigmática e autodestrutiva.', @ISBN = '978-858-057088-7', @NumPaginas = 256, @CapaURL = 'https://bibliotecavirtual.com/capas/quem_e_voce_alasca.jpg', @EditoraId = 13;
EXEC adicionarLivro @Titulo = 'O Nome da Rosa', @Sinopse = 'Um mistério medieval na Itália, onde um frade franciscano e seu noviço investigam uma série de mortes em um mosteiro isolado.', @ISBN = '978-850-102573-0', @NumPaginas = 560, @CapaURL = 'https://bibliotecavirtual.com/capas/nome_da_rosa.jpg', @EditoraId = 2;
EXEC adicionarLivro @Titulo = 'Mulheres Que Correm Com os Lobos', @Sinopse = 'Uma análise de mitos, contos de fadas e arquétipos para ajudar as mulheres a redescobrirem sua força interior e instintos selvagens.', @ISBN = '978-853-250917-9', @NumPaginas = 576, @CapaURL = 'https://bibliotecavirtual.com/capas/mulheres_lobos.jpg', @EditoraId = 2;
EXEC adicionarLivro @Titulo = 'Box A Roda do Tempo: O Olho do Mundo', @Sinopse = 'Primeiro volume de uma épica saga de fantasia. Rand al''Thor e seus amigos devem fugir de sua vila após serem atacados por criaturas das trevas.', @ISBN = '978-858-057999-6', @NumPaginas = 672, @CapaURL = 'https://bibliotecavirtual.com/capas/olho_do_mundo.jpg', @EditoraId = 5;
EXEC adicionarLivro @Titulo = 'O Senhor das Moscas', @Sinopse = 'Um grupo de meninos britânicos isolados em uma ilha deserta tentam se autogovernar, mas a natureza humana primitiva logo se manifesta.', @ISBN = '978-853-252971-9', @NumPaginas = 224, @CapaURL = 'https://bibliotecavirtual.com/capas/senhor_moscas.jpg', @EditoraId = 2;


SELECT * FROM Livro


--Inserindo Generos
INSERT INTO Genero (NomeGenero) VALUES
('Clássico'),                           
('Romance'),                            
('Fantasia'),                           
('Ficção Científica'),                  
('Literatura Brasileira'),              
('Distopia'),                           
('Mistério'),                           
('Policial'),                           
('Realismo Mágico'),                    
('Histórico'),                          
('Suspense'),                           
('Thriller'),                           
('Não-Ficção'),                         
('Autoajuda'),                         
('Desenvolvimento Pessoal'),            
('Biografia'),                          
('Terror'),                             
('Horror'),                             
('Literatura Juvenil');


-- Populando a tabela LivroGenero

INSERT INTO LivroGenero (LivroId, GeneroId) VALUES
(1, 1), (1, 5), (1, 2),
(2, 1), (2, 5),
(3, 1), (3, 5),
(4, 2), (4, 3), (4, 14), (4, 15),
(5, 1), (5, 6), (5, 4),
(6, 1), (6, 9),
(7, 3), (7, 19), (7, 1),
(8, 1), (8, 2),
(9, 1), (9, 2), (9, 8),
(10, 1), (10, 7), (10, 8),
(11, 2),
(12, 12), (12, 11),
(13, 3), (13, 2),
(14, 2),
(15, 2), (15, 5),
(16, 3), (16, 19),
(17, 12), (17, 11),
(18, 13), (18, 10),
(19, 13), (19, 15),
(20, 13), (20, 15),
(21, 14), (21, 15),
(22, 14), (22, 15),
(23, 13), (23, 4),
(24, 2), (24, 19),
(25, 2), (25, 19),
(26, 10), (26, 2),
(27, 3),
(28, 12), (28, 7), (28, 10),
(29, 6), (29, 4), (29, 1),
(30, 6), (30, 1),
(31, 1), (31, 2), (31, 10),
(32, 3),
(33, 3), (33, 9),
(34, 3), (34, 2),
(35, 12), (35, 11),
(36, 1), (36, 7), (36, 8),
(37, 11), (37, 12),
(38, 12), (38, 11), (38, 18),
(39, 14), (39, 15),
(40, 14), (40, 15),
(41, 13), (41, 15),
(42, 16), (42, 13),
(43, 13), (43, 15),
(44, 13),
(45, 1), (45, 5),
(46, 1), (46, 5), (46, 9),
(47, 1), (47, 2),
(48, 1), (48, 5), (48, 2),
(49, 1), (49, 2),
(50, 9), (50, 3),
(51, 3), (51, 19),
(52, 2), (52, 10), (52, 3),
(53, 11), (53, 17),
(54, 12), (54, 11),
(55, 2), (55, 19),
(56, 7), (56, 8), (56, 10),
(57, 13), (57, 15),
(58, 3),
(59, 1), (59, 6);

SELECT * FROM LivroGenero


-- Definindo Autores

INSERT INTO Autor (NomeAutor) VALUES
('Machado de Assis'),
('Jorge Amado'),
('Graciliano Ramos'),
('Paulo Coelho'),
('George Orwell'),
('Gabriel García Márquez'),
('Antoine de Saint-Exupéry'),
('Jane Austen'),
('Fiódor Dostoiévski'),
('Arthur Conan Doyle'),
('Colleen Hoover'),
('Matt Haig'),
('Taylor Jenkins Reid'),
('Carla Madeira'),
('J. K. Rowling'),
('Alex Michaelides'),
('Yuval Noah Harari'),
('Charles Duhigg'),
('Carol S. Dweck'),
('Dale Carnegie'),
('Robert Kiyosaki'),  
('Sharon Lechter'),    
('Stephen Hawking'),
('John Green'),
('R. J. Palacio'),
('Markus Zusak'),
('Patrick Rothfuss'),
('Dan Brown'),
('Ray Bradbury'),
('Charles Dickens'),
('Brandon Sanderson'),
('Diana Wynne Jones'),
('Sarah J. Maas'),
('Gillian Flynn'),
('Agatha Christie'),
('Paula Hawkins'),
('Thomas Harris'),
('Rhonda Byrne'),
('James Clear'),
('Robert B. Cialdini'),
('Ashlee Vance'),
('Cal Newport'),
('Leonard Mlodinow'),
('Guimarães Rosa'),
('Gustave Flaubert'),
('Clarice Lispector'),
('Eça de Queirós'),
('Haruki Murakami'),
('C. S. Lewis'),
('Carina Rissi'),
('Stephen King'),
('Jessica Knoll'),
('Umberto Eco'),
('Clarissa Pinkola Estés'),
('Robert Jordan'),
('William Golding');

SELECT * FROM Autor


-- Populando a tabela LivroAutor

INSERT INTO LivroAutor (LivroId, AutorId) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10),
(11, 11),
(12, 11),
(13, 12),
(14, 13),
(15, 14),
(16, 15),
(17, 16),
(18, 17),
(19, 18),
(20, 19),
(21, 20),
(22, 21),
(22, 22),
(23, 23),
(24, 24),
(25, 25),
(26, 26),
(27, 27),
(28, 28),
(29, 29),
(30, 5),
(31, 30),
(32, 31),
(33, 32),
(34, 33),
(35, 34),
(36, 35),
(37, 36),
(38, 37),
(39, 38),
(40, 39),
(41, 40),
(42, 41),
(43, 42),
(44, 43),
(45, 1),
(46, 44),
(47, 45),
(48, 46),
(49, 47),
(50, 48),
(51, 49),
(52, 50),
(53, 51),
(54, 52),
(55, 24),
(56, 53),
(57, 54),
(58, 55),
(59, 56);

SELECT * FROM LivroAutor


-- Estado de Leitura

INSERT INTO EstadoLeitura(Estado)
VALUES
('Quero Ler'),
('Lendo'),
('Lido');

SELECT * FROM EstadoLeitura
