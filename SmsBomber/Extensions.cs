using Leaf.xNet;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmsBomber
{
    internal static class Extensions
    {
        /// <summary>
        /// Проверяет последний HTTP запрос, было ли подключение к сайту
        /// </summary>
        /// <param name="request">Экземляр класса с запросом</param>
        /// <returns>Возвращает True если было, false если нет</returns>
        public static bool HttpIsConnected(this HttpRequest request)
        {
            if (request.Response.StatusCode == HttpStatusCode.None)
                return false;

            return true;
        }

        /// <summary>
        /// Получить кол-во запущеных Task`ов
        /// </summary>
        /// <param name="taskList">Массив с Task`aми</param>
        /// <returns>Кол-во запущенных Task`ов</returns>
        public static int GetRunningTaskListCount(this List<Task> taskList)
        {
            int i = 0;

            foreach (var item in taskList)
                if (item.Status == TaskStatus.Running)
                    i++;

            return i;
        }
    }
}
