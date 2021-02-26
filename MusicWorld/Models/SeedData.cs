using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MusicWorld.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicWorld.Models
{
    public class SeedData
    {
        public static void EnsurePopulate(IApplicationBuilder app)
        {
            MusicDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<MusicDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (context.Events.Any())
            {
                return;
            }

            var events = new Event[]
           {
               new Event
                {
                    Title = "Kỉ Niệm 151 năm Sinh LEHAR",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Hà Nội",
                    StartingDate = "3/10/2019",
                     UrlImage = "sk1.jpg"
                },
                new Event
                {
                    Title = "Kỉ Niệm 188 năm sinh BARAHMS",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Nha Trang",
                    StartingDate = "3/10/2019",
                     UrlImage = "sk2.jpg"
                },
                new Event
                {
                    Title = "Kỉ Niệm 188 năm sinh MASSENET",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Phú Xuyên",
                    StartingDate = "3/10/2019",
                     UrlImage = "sk3.jpg"
                },
                new Event
                {
                    Title = "Kỉ Niệm 188 năm sinh ALBENIZ",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "HN",
                    StartingDate = "3/10/2019",
                     UrlImage = "sk4.jpg"
                },
                new Event
                {
                    Title = "Kỉ Niệm 190 năm sinh MASSENET",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Nha Trang",
                    StartingDate = "3/10/2019",
                     UrlImage = "sk5.jpg"
                },
                new Event {
                  Title = "Đại Nhạc Hội REALME",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "HN",
                    StartingDate = "3/10/2019",
                    UrlImage = "sk_1.jpg"
                },
                new Event {
                  Title = "CountDown",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Nha Trang",
                    StartingDate = "3/10/2019",
                    UrlImage = "sk_2.jpg"
                },
                new Event {
                  Title = "Đại Nhạc Hội TP.BANK",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Ha Noi",
                    StartingDate = "2/02/2021",
                    UrlImage = "sk_3.jpg"
                },
                new Event {
                  Title = "Music Awards",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Hong Khong",
                    StartingDate = "5/12/2021",
                    UrlImage = "sk_4.jpg"
                },
                new Event {
                  Title = "Dạ khúc cho tình nhân",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Ha Noi",
                    StartingDate = "29/12/2020",
                    UrlImage = "sk_5.jpg"
                },
                new Event
                {
                    Title = "This Is It",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Anh",
                    StartingDate = "13/7/2009",
                    UrlImage = "This Is It.jpg"
                },
                new Event
                {
                    Title = "Pacific Rim Tour",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "USA",
                    StartingDate = "5/5/1997",
                    UrlImage = "RimTour.jpg"
                },
                new Event
                {
                    Title = "25 Live",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "Ba Lan",
                    StartingDate = "11/7/2017",
                    UrlImage = "25 Live.jpg"
                },
                new Event
                {
                    Title = "Back to Basics Tour",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "World",
                    StartingDate = "17/11/2016",
                    UrlImage = "Back Tour.jpg"
                },
                new Event
                {
                    Title = "The Fame Ball Tour",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "World",
                    StartingDate = "12/3/2009",
                    UrlImage = "The Fame Ball Tour.jpg"
                },
                new Event
                {
                    Title = "Beyond The Future 2020",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "VN",
                    StartingDate = "7/11/2020",
                    UrlImage = "Beyond The Future.jpg"
                },
                new Event
                {
                    Title = "Shopee 11.11",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "VN",
                    StartingDate = "11/11/2020",
                    UrlImage = "Shopee Show.jpg"
                },
                new Event
                {
                    Title = "GaLa Nimo TV",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "VN",
                    StartingDate = "22/1/2021",
                    UrlImage = "Justatee Nimo.jpg"
                },
                new Event
                {
                    Title = "WeChoice Awards 2019",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "VN",
                    StartingDate = "12/1/2020",
                    UrlImage = "Wechoice Đen.jpg"
                },
                new Event
                {
                    Title = "Elle Show 2020",
                    Description = "",
                    TicketPrice = "100000",
                    Place = "VN",
                    StartingDate = "1/8/2020",
                    UrlImage = "Elle Show.jpg"
                }
           };
            foreach (Event e in events)
            {
                context.Events.Add(e);
            }
            context.SaveChanges();
            if (context.Artists.Any())
            {
                return;
            }
            var artists = new Artist[]
               {
                    new Artist
                        {
                                Name = "Michael Jackson",
                                Birthday = "29/8/1958",
                                Gender = "Nam",
                                Contact = "Michael Jackson.com",
                                UrlImage = "MichaelJackson.jpg",
                                EventId = events.Single(e=> e.Title == "This Is It").Id
                        },
                        new Artist
                        {
                            Name = "Whitney Houston",
                                Birthday = "9/8/1963",
                                Gender = "Nữ",
                                Contact = "WhitneyHouston.com",
                                UrlImage = "WhitneyHouston.jpg",
                                EventId = events.Single(e=> e.Title == "Pacific Rim Tour").Id
                        },
                        new Artist
                        {
                            Name = "George Michael",
                                Birthday = "25/6/1963",
                                Gender = "Nam",
                                Contact = "George Michael.com",
                                UrlImage = "GeorgeMichael.jpg",
                                EventId = events.Single(e=> e.Title == "25 Live").Id
                        },
                        new Artist
                        {
                            Name = "Christina María Aguilera ",
                                Birthday = "18/12/1980",
                                Gender = "Nữ",
                                Contact = "Christina María Aguilera.com",
                                UrlImage = "ChristinaMaríaAguilera.jpg",
                                EventId = events.Single(e=> e.Title == "Back to Basics Tour").Id
                        },
                        new Artist
                        {
                            Name = "Lady Gaga",
                                Birthday = "28/3/1985",
                                Gender = "Nữ",
                                Contact = "Lady Gaga.com",
                                UrlImage = "LadyGaga.jpg",
                                EventId = events.Single(e=> e.Title == "The Fame Ball Tour").Id
                        },
                        new Artist
                        {
                            Name = "BinZ",
                                Birthday = "24/5/1988",
                                Gender = "Nam",
                                Contact = "Binz.com",
                                UrlImage = "Binz.jpg",
                                EventId = events.Single(e=> e.Title == "GaLa Nimo TV").Id
                        },
                        new Artist
                        {
                            Name = "Karik",
                                Birthday = "12/4/1989",
                                Gender = "Nam",
                                Contact = "Karik.com",
                                UrlImage = "Karik.jpg",
                                EventId = events.Single(e=> e.Title == "Beyond The Future 2020").Id
                        },
                        new Artist
                        {
                            Name = "Rhymastic",
                                Birthday = "8/4/1991",
                                Gender = "Nam",
                                Contact = "Rhymastic.com",
                                UrlImage = "Rhymastic.jpg",
                                EventId = events.Single(e=> e.Title == "Shopee 11.11").Id
                        },

                        new Artist
                        {
                            Name = "Justatee",
                                Birthday = "1/11/1991",
                                Gender = "Nam",
                                Contact = "Justatee.com",
                                UrlImage = "Justatee.jpg",
                                EventId = events.Single(e=> e.Title == "GaLa Nimo TV").Id
                        },
                        new Artist
                        {
                            Name = "Đen Vâu",
                                Birthday = "13/5/1989",
                                Gender = "Nam",
                                Contact = "Đen.com",
                                UrlImage = "Denvau.jpg",
                                EventId = events.Single(e=> e.Title == "WeChoice Awards 2019").Id
                        },
                        new Artist
                        {
                            Name = "Wowy",
                                Birthday = "27/9/1988",
                                Gender = "Nam",
                                Contact = "Wowy.com",
                                UrlImage = "Wowy.jpg",
                                EventId = events.Single(e=> e.Title == "Elle Show 2020").Id
                        },
                        new Artist {
                          Name = "Hồ Trung Dũng",
                            Birthday = "12/1/1982",
                            Gender = "Nam",
                            Contact = "hotrungdung.com",
                            UrlImage = "Hotrungdung.jpg",
                            EventId = events.Single(e => e.Title == "CountDown").Id
                        },
                        new Artist {
                          Name = "Trần Mạnh Tuấn",
                            Birthday = "7/5/1970",
                            Gender = "Nam",
                            Contact = "tranmanhtuan.com",
                            UrlImage = "Tranmanhtuan.jpg",
                            EventId = events.Single(e => e.Title == "CountDown").Id
                        },
                        new Artist {
                          Name = "Imagine Dragons",
                            Birthday = "1/1/2012",
                            Gender = "Nam",
                            Contact = "imaginedragonsmusic.com",
                            UrlImage = "ImagineDragons.jpg",
                            EventId = events.Single(e => e.Title == "Đại Nhạc Hội REALME").Id
                        },
                        new Artist {
                          Name = "Đức Tuấn",
                            Birthday = "2/6/1980",
                            Gender = "Nam",
                            Contact = "media.ductuan@gmail.com",
                            UrlImage = "Ductuan.jpg",
                            EventId = events.Single(e => e.Title == "Đại Nhạc Hội REALME").Id
                        },
                        new Artist {
                          Name = "Trần Lập",
                            Birthday = "12/12/1974",
                            Gender = "Nam",
                            Contact = "tranlap.com",
                            UrlImage = "TranLap.jpg",
                            EventId = events.Single(e => e.Title == "Đại Nhạc Hội TP.BANK").Id
                        },
                        new Artist {
                          Name = "Ngọt",
                            Birthday = "1/1/2013",
                            Gender = "Nam",
                            Contact = "hoangvp102@gmail.com",
                            UrlImage = "Ngot.jpg",
                            EventId = events.Single(e => e.Title == "Đại Nhạc Hội TP.BANK").Id
                        },
                        new Artist {
                          Name = "Mr.siro",
                            Birthday = " 18/11/1982",
                            Gender = "Nam",
                            Contact = "facebook.com/mrsiro.vuongquoctuan",
                            UrlImage = "mrsiro.jpg",
                            EventId = events.Single(e => e.Title == "Music Awards").Id
                        },
                        new Artist {
                          Name = "Trung Quân",
                            Birthday = "20/1/1989",
                            Gender = "Nam",
                            Contact = "soundcloud.com/quancartoon",
                            UrlImage = "trungquan.jpg",
                            EventId = events.Single(e => e.Title == "Music Awards").Id
                        },
                        new Artist {
                          Name = "Bích Phương",
                            Birthday = "30/9/1989",
                            Gender = "Nữ",
                            Contact = "contact@1989s.vn",
                            UrlImage = "bichphuong.jpg",
                            EventId = events.Single(e => e.Title == "Dạ khúc cho tình nhân").Id
                        },
                        new Artist {
                          Name = "Soobin Hoàng Sơn",
                            Birthday = "10/9/1992",
                            Gender = "Nữ",
                            Contact = "soobin.vn",
                            UrlImage = "soobinhoangson.jpg",
                            EventId = events.Single(e => e.Title == "Dạ khúc cho tình nhân").Id
                        },
                        new Artist
                        {
                                Name = "YO YO MA",
                                Birthday = "7/10/1955",
                                Gender = "Nam",
                                UrlImage = "yoma.jpg",
                                 EventId = events.Single(e=> e.Title == "Kỉ Niệm 151 năm Sinh LEHAR").Id
                        },
                        new Artist
                        {
                                Name = "Jacques Loussier Trio",
                                Birthday = "26/10/1934",
                                Gender = "Nam",
                                UrlImage = "trio.jpg",
                                EventId = events.Single(e=> e.Title == "Kỉ Niệm 188 năm sinh BARAHMS").Id
                        },
                        new Artist
                        {
                             Name = "Artur Rubinstein",
                                Birthday = "28/1/1887",
                                Gender = "Nam",
                                UrlImage = "rubinstein.jpg",
                                EventId = events.Single(e=> e.Title == "Kỉ Niệm 188 năm sinh MASSENET").Id
                        },
                        new Artist
                        {
                             Name = "Jean François Paillard",
                                Birthday = "14/4/1928",
                                Gender = "Nam",
                                UrlImage = "paillard.jpg",
                                EventId = events.Single(e=> e.Title == "Kỉ Niệm 188 năm sinh ALBENIZ").Id
                        },
                        new Artist
                        {
                            Name = "Alicia De Larrocha",
                                Birthday = "23/5/1923",
                                Gender = "Nữ",
                                UrlImage = "larrocha.jpg",
                                EventId = events.Single(e=> e.Title == "Kỉ Niệm 190 năm sinh MASSENET").Id
                        }
                };

            foreach (Artist a in artists)
            {
                context.Artists.Add(a);
            }
            context.SaveChanges();
            if (context.Albums.Any())
            {
                return;
            }
            var albums = new Album[]
            {
                new Album
                {
                    Title ="Những Bản nhạc cổ điển hay",
                    Description = "Những bài cổ điển hát hay tiêu biểu hay nhất được zingmp3 tuyển chọn",
                    ReleaseDate = "12/7/2001",
                    UrlImage = "abum1.jpg"
                },
                 new Album
                {
                    Title ="Những bài hát cổ diển được nghe nhiều nhất ",
                    Description = "Những bài hát cổ điển được nghe nhiều nhất được zingmp3 tuyển chọn",
                    ReleaseDate = "12/7/2001",
                    UrlImage = "abum2.jpg"
                },
                 new Album
                {
                    Title ="Top HITS cổ điển",
                    Description = "Những bài hát hay tiêu biểu hay nhất được zingmp3 tuyển chọn",
                    ReleaseDate = "12/7/2001",
                    UrlImage = "abum3.jpg"
                },
                new Album
                {
                    Title ="Cảm nhận âm nhạc cổ điển ",
                    Description = "Những bản giao hưởng tuyệt vời",
                    ReleaseDate = "12/7/2001",
                    UrlImage = "abum4.jpg"
                },
                new Album
                {
                    Title ="Nghe và cảm nhận ",
                    Description = "Những bản giao hưởng tuyệt vời",
                    ReleaseDate = "12/7/2001",
                    UrlImage = "abum5.jpg"
                },
                new Album
                {
                    Title ="Top Trending youtube",
                    Description = "Những bài hát hay tiêu biểu hay nhất được zingmp3 tuyển chọn",
                    ReleaseDate = "5/1/2020",
                    UrlImage = "album5.jpg"
                },
                  new Album
                {
                    Title ="Rap Việt hay",
                    Description = "Những bài hát hay tiêu biểu hay nhất được zingmp3 tuyển chọn",
                    ReleaseDate = "5/1/2020",
                    UrlImage = "album5.jpg"
                },
                new Album {
                  Title = "Top HITS của năm",
                    Description = "Những bài hát hay tiêu biểu hay nhất được zingmp3 tuyển chọn",
                    ReleaseDate = "5/1/2020",
                    UrlImage = "album5.jpg"
                },
                new Album {
                  Title = "Những bài hát được nghe nhiều",
                    Description = "Những bài hát hay tiêu biểu hay nhất được zingmp3 tuyển chọn",
                    ReleaseDate = "5/1/2020",
                    UrlImage = "album4.jpg"
                },
                new Album {
                  Title = "Những bản nhạc jazz hay nhất",
                    Description = "Tuyển tập 10 bản nhạc Jazz do Zing MP3 chọn lựa. Cùng thư giãn với Playlist này nhé! ",
                    ReleaseDate = "3/1/2020",
                    UrlImage = "album3.jpg"
                },
                new Album {
                  Title = "Chặng Đường Rock Việt",
                    Description = "Lời tựa Nhìn lại một chặng đường của Rock Việt với chất Rock đầy sáng tạo và gai góc của Bức Tường, Microwave... đến những nhân tố mới đầy triển vọng như Bụi Gió, Cá Hồi Hoang…",
                    ReleaseDate = "2/1/2020",
                    UrlImage = "album2.jpg"
                },
                new Album {
                  Title = "Những bản nhạc việt hiện đại",
                    Description = "Những bản nhạc mới mang hướng mới lạ trong nước và hướng tới cả khán giả quốc tế..",
                    ReleaseDate = "1/1/2020",
                    UrlImage = "album_1.jpg"
                }
            };
            foreach (Album a in albums)
            {
                context.Albums.Add(a);
            }
            context.SaveChanges();
            if (context.Songs.Any())
            {
                return;
            }
            var songs = new Song[]
            {
                 new Song
                {
                        Title = "OK",
                        Author = "BinZ",
                        UrlImage = "OK.jpg",
                        UrlMp3 = "Ok.mp3",
                        Category = "Rap",
                        ArtistsId = artists.Single(a => a.Name == "BinZ").Id,
                        AlbumsId = albums.Single(a => a.Title == "Rap Việt hay").Id
                },
                 new Song
                {
                        Title = "Yêu em quá đi",
                        Author = "Karik",
                        UrlImage = "Yeuemquadi.jpg",
                        UrlMp3="YeuEmQuaDi.mp3",
                        Category = "Pop",
                        ArtistsId = artists.Single(a => a.Name == "Karik").Id,
                        AlbumsId = albums.Single(a => a.Title == "Rap Việt hay").Id
                },
                 new Song
                {
                        Title = "Từng là tất cả",
                        Author = "Karik",
                        UrlImage = "Tunglatatca.jpg",
                        UrlMp3 = "TungLaTatCa.mp3",
                        Category = "Pop",
                        ArtistsId = artists.Single(a => a.Name == "Karik").Id,
                        AlbumsId = albums.Single(a => a.Title == "Rap Việt hay").Id
                },
                 new Song
                {
                        Title = "Không ổn",
                        Author = "Karik",
                        UrlImage = "Khongon.jpg",
                        UrlMp3 = "KhongOn.mp3",
                        Category = "Pop",
                        ArtistsId = artists.Single(a => a.Name == "Karik").Id,
                        AlbumsId = albums.Single(a => a.Title == "Top Trending youtube").Id
                },
                     new Song
                {
                        Title = "Crying Over You",
                        Author = "Justatee",
                        UrlImage = "Crying.jpg",
                        UrlMp3="CryingOverYou.mp3",
                        Category = "Pop",
                        ArtistsId = artists.Single(a => a.Name == "Justatee").Id,
                        AlbumsId = albums.Single(a => a.Title == "Rap Việt hay").Id
                },
                      new Song
                {
                        Title = "Đố em biết anh đang nghĩ gì",
                        Author = "Đen Vâu",
                        UrlImage = "Doembiet.jpg",
                        UrlMp3="DoEmBietAnhDangNghiGiMadihuRemix.mp3",
                        Category = "Rap",
                        ArtistsId = artists.Single(a => a.Name == "Đen Vâu").Id,
                        AlbumsId = albums.Single(a => a.Title == "Top Trending youtube").Id
                },
                       new Song
                {
                        Title = "Hai triệu năm",
                        Author = "Đen Vâu",
                        UrlImage = "2trieunam.jpg",
                        UrlMp3="HaiTrieuNam-DenBien-6007307.mp3",
                        Category = "Rap",
                        ArtistsId = artists.Single(a => a.Name == "Đen Vâu").Id,
                        AlbumsId = albums.Single(a => a.Title == "Top Trending youtube").Id
                },
                        new Song
                {
                        Title = "Cảm ơn",
                        Author = "Đen Vâu",
                        UrlImage = "denvau.jpg",
                        UrlMp3="CamOn.mp3",
                        Category = "Rap",
                        ArtistsId = artists.Single(a => a.Name == "Đen Vâu").Id,
                        AlbumsId = albums.Single(a => a.Title == "Rap Việt hay").Id
                },
                        new Song
                {
                        Title = "Thiên đàng",
                        Author = "Wowy",
                        UrlImage = "Thiendang.jpg",
                        UrlMp3="ThienDangLive-WowyPhamDangAnhThu-6722192.mp3",
                        Category = "Rap",
                        ArtistsId = artists.Single(a => a.Name == "Wowy").Id,
                        AlbumsId = albums.Single(a => a.Title == "Top Trending youtube").Id
                },
                        new Song
                {
                        Title = "Bay thật xa",
                        Author = "Wowy",
                        UrlImage = "Bay.jpg",
                        UrlMp3="BayThatXa.mp3",
                        Category = "Rap",
                        ArtistsId = artists.Single(a => a.Name == "Wowy").Id,
                        AlbumsId = albums.Single(a => a.Title == "Rap Việt hay").Id
                },
                        new Song
                {
                        Title = "Hướng dương",
                        Author = "Wowy",
                        UrlImage = "Huongduong.jpg",
                        UrlMp3 = "QueHuong-TranManhTuan_qn24.mp3",
                        Category = "Rap",
                        ArtistsId = artists.Single(a => a.Name == "Wowy").Id,
                        AlbumsId = albums.Single(a => a.Title == "Top Trending youtube").Id
                },
                        new Song {
                  Title = "Một Bước Yêu Vạn Dặm Đau",
                    Author = "Mr.siro",
                    UrlImage = "mrsiro_1.jpg",
                    UrlMp3 = "MotBuocYeuVanDamDauCover-HuongTra-5948455.mp3",
                    Category = "Ballad",
                    ArtistsId = artists.Single(a => a.Name == "Mr.siro").Id,
                    AlbumsId = albums.Single(a => a.Title == "Top HITS của năm").Id
                },
                new Song {
                  Title = "Lắng Nghe Nước Mắt",
                    Author = "Mr.siro",
                    UrlImage = "mrsiro_2.jpg",
                    UrlMp3 = "LangNgheNuocMat-MrSiro-2558535.mp3",
                    Category = "Ballad",
                    ArtistsId = artists.Single(a => a.Name == "Mr.siro").Id,
                    AlbumsId = albums.Single(a => a.Title == "Những bản nhạc việt hiện đại").Id
                },
                new Song {
                  Title = "Chiều nay không có mưa bay",
                    Author = "Trung Quân",
                    UrlImage = "trungquan_1.jpg",
                    UrlMp3 = "ChieuNayKhongCoMuaBay.mp3",
                    Category = "Ballad",
                    ArtistsId = artists.Single(a => a.Name == "Trung Quân").Id,
                    AlbumsId = albums.Single(a => a.Title == "Những bài hát được nghe nhiều").Id
                },
                new Song {
                  Title = "Dấu Mưa",
                    Author = "Trung Quân",
                    UrlImage = "trungquan_2.jpg",
                    UrlMp3 = "DauMua-TrungQuanIdol.mp3",
                    Category = "Balland",
                    ArtistsId = artists.Single(a => a.Name == "Trung Quân").Id,
                    AlbumsId = albums.Single(a => a.Title == "Những bài hát được nghe nhiều").Id
                },
                new Song {
                  Title = "Bèo dạt mây trôi",
                    Author = "Trần Mạnh Tuấn",
                    UrlImage = "Tranmanhtuan_1.jpg",
                    UrlMp3 = "Beodatmaytroi.mp3",
                    Category = "Jazz",
                    ArtistsId = artists.Single(a => a.Name == "Trần Mạnh Tuấn").Id,
                    AlbumsId = albums.Single(a => a.Title == "Những bản nhạc jazz hay nhất").Id
                },
                new Song {
                  Title = "Quê Hương",
                    Author = "Trần Mạnh Tuấn",
                    UrlImage = "Tranmanhtuan_2.jpg",
                    UrlMp3 = "QueHuong-TranManhTuan_qn24.mp3",
                    Category = "Jazz",
                    ArtistsId = artists.Single(a => a.Name == "Trần Mạnh Tuấn").Id,
                    AlbumsId = albums.Single(a => a.Title == "Những bản nhạc jazz hay nhất").Id
                },
                new Song {
                  Title = "Đường Đến Vinh Quang",
                    Author = "Trần Lập",
                    UrlImage = "TranLap_1.jpg",
                    UrlMp3 = "DuongDenVinhQuang-TranLap_t7tp.mp3",
                    Category = "Rock",
                    ArtistsId = artists.Single(a => a.Name == "Trần Lập").Id,
                    AlbumsId = albums.Single(a => a.Title == "Chặng Đường Rock Việt").Id
                },
                new Song {
                  Title = "Tâm Hồn Của Đá ",
                    Author = "Trần Lập",
                    UrlImage = "TranLap_2.jpg",
                    UrlMp3 = "Tamhoncuada-BucTuong_mmc3.mp3",
                    Category = "Rock",
                    ArtistsId = artists.Single(a => a.Name == "Trần Lập").Id,
                    AlbumsId = albums.Single(a => a.Title == "Chặng Đường Rock Việt").Id
                },
                new Song {
                  Title = "Bao giờ lấy chồng",
                    Author = "Bích Phương",
                    UrlImage = "bichphuong_3.jpg",
                    UrlMp3 = "BaoGioLayChong.mp3",
                    Category = "Ballad",
                    ArtistsId = artists.Single(a => a.Name == "Bích Phương").Id,
                    AlbumsId = albums.Single(a => a.Title == "Những bản nhạc việt hiện đại").Id
                },
                new Song {
                  Title = "Em bỏ hút thuốc chưa",
                    Author = "Bích Phương",
                    UrlImage = "bichphuong_5.jpg",
                    UrlMp3 = "EmBoHutThuocChua.mp3",
                    Category = "Ballad",
                    ArtistsId = artists.Single(a => a.Name == "Bích Phương").Id,
                    AlbumsId = albums.Single(a => a.Title == "Những bản nhạc việt hiện đại").Id
                },
                 new Song
                {
                        Title = "The Legend of 1900 Playing love",
                        Author = "YO YO MA",
                        UrlImage = "baihat3.jpg",
                        UrlMp3 = "TheLegendOf1900PlayingLove-YoYoMa_4ahrp.mp3",
                        Category = "Classical",
                        ArtistsId = artists.Single(a => a.Name == "YO YO MA").Id,
                        AlbumsId = albums.Single(a => a.Title == "Những Bản nhạc cổ điển hay").Id
                }
            };
            foreach (Song s in songs)
            {
                context.Songs.Add(s);
            }
            context.SaveChanges();
        }
    }
}