using _2023_11_30_ClassTask;
using System;

ProgressBar progressBar = new ProgressBar();

async Task AddOne()
{    
    for (int i = 0; i < 100; i++)
    {
        await Task.Delay(1000);
        progressBar.progress++;

    }
    
}

async Task ShowProgress()
{
    Task.Run(() => AddOne());
    Console.WriteLine(progressBar.progress.ToString());
    await Task.Delay(3000);
}

//async Task Start()
//{



//    ShowProgress();
//    await Task.Run(() => AddOne());


//}
//await Start();

ShowProgress();   