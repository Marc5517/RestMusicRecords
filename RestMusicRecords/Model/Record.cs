using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestMusicRecords.Model
{
    public class Record
    {
        private int _nr;
        private string _title;
        private string _artist;
        private int _duration;
        private int _yearOfPublication;

        public Record()
        {

        }

        public Record(int nr, string title, string artist, int duration, int yearOfPublication)
        {
            _nr = nr;
            _title = title;
            _artist = artist;
            _duration = duration;
            _yearOfPublication = yearOfPublication;
        }

        public int Nr
        {
            get => _nr;
            set
            {
                _nr = value;
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
            }
        }

        public string Artist
        {
            get => _artist;
            set
            {
                _artist = value;
            }
        }

        public int Duration
        {
            get => _duration;
            set
            {
                _duration = value;
            }
        }

        public int YearOfPublication
        {
            get => _yearOfPublication;
            set
            {
                _yearOfPublication = value;
            }
        }

        public override string ToString()
        {
            return $"{Title} Nr: {Nr}";
        }
    }
}
