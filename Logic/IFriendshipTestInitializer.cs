using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IFriendshipTestInitializer
    {
        QuestionsInitializer[] InitializeQuestions(FacebookUserProxy i_DataManager);

        QuestionsInitializer[] QuestionsForm { get; }

        User CurrentUser { get; set; }

        int Score { get; }
        int GetScore(int[] i_ArrayOfUserAnswers);
    }
}
