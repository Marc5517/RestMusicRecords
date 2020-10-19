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
                value = _nr;
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                value = _title;
            }
        }

        public string Artist
        {
            get => _artist;
            set
            {
                value = _artist;
            }
        }

        public int Nr
        {
            get => _nr;
            set
            {
                value = _nr;
            }
        }

        public int Nr
        {
            get => _nr;
            set
            {
                value = _nr;
            }
        }
    }
}
