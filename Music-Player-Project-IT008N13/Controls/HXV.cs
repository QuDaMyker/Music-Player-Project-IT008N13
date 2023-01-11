using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HXV
{
    public class Mp3Tag
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Year { get; set; }
        public string Genere { get; set; }
        public string Comment { get; set; }
    }
    public class Mp3Reader
    {
        private string _fileName;
        private Stream _stream;
        private byte[] data;
        private int width, height;
        private const int SIZE = 128;
        public Mp3Reader(string fileName)
        {

            this._fileName = fileName;
            this._stream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
        }
        public Mp3Tag GetTag()
        {
            Mp3Tag tag = new Mp3Tag();
            data = new byte[SIZE];
            _stream.Seek(-128, SeekOrigin.End);
            _stream.Read(data, 0, SIZE);
            _stream.Close();
            byte b1 = data[0];
            byte b2 = data[1];
            byte b3 = data[2];
            if ((Convert.ToChar(b1) != 'T') || (Convert.ToChar(b2) != 'A') || (Convert.ToChar(b3) != 'G'))
            {
                throw new Exception("This File is NOT a MP3 file with ID3 v1");

            }
            for (int i = 3; i < 33; i++)
            {
                if (data[i] != 0)
                    tag.Title += Convert.ToChar(data[i]);
            }
            for (int i = 33; i < 63; i++)
            {
                if (data[i] != 0)
                    tag.Artist += Convert.ToChar(data[i]);
            }
            for (int i = 63; i < 93; i++)
            {
                if (data[i] != 0)
                    tag.Album += Convert.ToChar(data[i]);
            }
            for (int i = 93; i < 97; i++)
            {
                if (data[i] != 0)
                    tag.Year += Convert.ToChar(data[i]);
            }

            for (int i = 97; i < 127; i++)
            {
                if (data[i] != 0)
                    tag.Comment += Convert.ToChar(data[i]);
            }
            tag.Genere = data[127].ToString();
            return tag;
        }
    }
}