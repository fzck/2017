	
  int main(){
  
  int freq = 440;
	int sampleRate = 44100;
	int numChannels = 1;
	int bitDepth = 16;
	

    double sampleRateAsFloat = (double) sampleRate;
    
    AudioFile<double> audioFile;
    
    audioFile.setAudioBufferSize (numChannels, sampleRate * 10);
    
    for (int i = 0; i < audioFile.getNumSamplesPerChannel(); i++)
    {
        double sample = sinf (1. * 3.14159 * ((double) i / sampleRateAsFloat) * freq * 360. *0.0174533) ;
        //cout << sample <<endl;
        
        for (int k = 0; k < audioFile.getNumChannels(); k++)
            audioFile.samples[k][i] = sample * 0.5;
            
    }
    
    audioFile.setSampleRate (sampleRate);
    audioFile.setBitDepth (bitDepth);
        
    bool ok = audioFile.setAudioBuffer (buffer);
    audioFile.save ("D:/2017-2/178/TRIAL2.wav");


	return 0;
