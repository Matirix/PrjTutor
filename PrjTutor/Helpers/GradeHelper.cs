using System.Collections;

namespace PrjTutor.Helpers;
public static class GradeHelper
{
    public static string GetGradeColor(double grade)
    {
        if (grade >= 90)
        {
            return "linear-gradient(90deg, #A8E6A3 0%, #A2D89C 100%)"; // Soft green gradient for A
        }
        else if (grade >= 80)
        {
            return "linear-gradient(90deg, #FFEB99 0%, #FFE68A 100%)"; // Soft yellow gradient for B
        }
        else if (grade >= 70)
        {
            return "linear-gradient(90deg, #FFD9A3 0%, #FFC894 100%)"; // Soft orange gradient for C
        }
        else if (grade >= 60)
        {
            return "linear-gradient(90deg, #FFB3A1 0%, #FFA292 100%)"; // Muted coral gradient for D
        }
        else
        {
            return "linear-gradient(90deg, #FF9999 0%, #FF8888 100%)"; // Soft red gradient for F
        }
    }

    public static Dictionary<int, string> GetGradeColorForCollection(ICollection<Evaluation> evaluations) {
        var gradeColors = new Dictionary<int, string>();
        foreach (var evaluation in evaluations) {
            string gradeColor = GetGradeColor(evaluation.Grade);
            gradeColors[evaluation.EvaluationId] = gradeColor;
        }
        return gradeColors;
        
    }
}