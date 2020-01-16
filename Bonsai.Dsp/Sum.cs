using OpenCV.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;

namespace Bonsai.Dsp
{
    [Combinator]
    [WorkflowElementCategory(ElementCategory.Transform)]
    [Description("Calculates the sum of all the array elements for each channel.")]
    public class Sum
    {
        public IObservable<Scalar> Process<TArray>(IObservable<TArray> source) where TArray : Arr
        {
            return source.Select(CV.Sum);
        }
    }
}
