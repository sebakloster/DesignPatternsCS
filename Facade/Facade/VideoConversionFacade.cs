using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class VideoConversionFacade
    {
        public File convertVideo(String fileName, String format)
        {
           Console.Write("VideoConversionFacade: conversion started.");
            VideoFile file = new VideoFile(fileName);
            Codec sourceCodec = CodecFactory.extract(file);
            Codec destinationCodec;
            if (format.equals("mp4"))
            {
                destinationCodec = new MPEG4CompressionCodec();
            }
            else
            {
                destinationCodec = new OggCompressionCodec();
            }
            VideoFile buffer = BitrateReader.read(file, sourceCodec);
            VideoFile intermediateResult = BitrateReader.convert(buffer, destinationCodec);
            File result = (new AudioMixer()).fix(intermediateResult);
            return result;
        }
    }
}
