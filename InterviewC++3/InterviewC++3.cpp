#include <iostream>
#include <vector>
#include <cmath>
#include <random>

bool shouldDropFrame(int timestamp, double targetFrameRate)
{
    // TODO: implement
    return false;
}

/// Creates a list of simple millisecond timestamps.
std::vector<int> generateTimestamps(int count, double frameRate) 
{
    std::vector<int> timestamps;
    int currentTime = 0;

    // Calculate the time interval between frames based on the frame rate
    int frameInterval = static_cast<int>(std::floor(1000 / frameRate));

    // Add a random jitter between -5 and 5
    std::default_random_engine e1(42);
    std::uniform_int_distribution<int> uniform_dist(-5, 5);

    for (int i = 0; i < count; ++i) {
        currentTime += frameInterval + uniform_dist(e1);
        timestamps.push_back(currentTime);
    }

    return timestamps;
}

double getAverageFrameRate(std::vector<int>& timestamps)
{
    double totalDuration = 0;

    for (size_t i = 1; i < timestamps.size(); ++i)
    {
        int interval = timestamps[i] - timestamps[i - 1];
        totalDuration += interval;
    }

    return 1000.0 / (totalDuration / timestamps.size());
}

int main()
{
    int frameCount = 100;
    double sourceFrameRate = 30;
    double targetFrameRate = 20;

    std::vector<int> timestamps = generateTimestamps(frameCount, sourceFrameRate);

    std::vector<int> output;
    for (int timestamp : timestamps)
    {
        if (!shouldDropFrame(timestamp, targetFrameRate))
            output.push_back(timestamp);
    }

    for (size_t i = 0; i < output.size(); ++i)
    {
        int interval = 0;
        if (i > 0)
            interval = timestamps[i] - output[i - 1];
        std::cout << "Frame time: " << output[i] << " | Interval: " << interval << std::endl;
    }

    std::cout << "Average frame rate: " << getAverageFrameRate(output) << std::endl;
}
