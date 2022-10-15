﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperVoters
{
    class Candidate
    {
        public int candidateId { get; set; }
        public string party { get; set; }
        public string candidateName { get; set; }
        public string candidateAddress { get; set; }
        public string candidatePhone { get; set; }
        public string description { get; set; }
        public int numberOfVotes { get; set; }
        public byte[] imageData { get; set; }

        public Candidate()
        { }
    }
}
