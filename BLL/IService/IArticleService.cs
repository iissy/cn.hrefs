﻿using ASY.Hrefs.Model.Models;
using System.Collections.Generic;

namespace ASY.Hrefs.BLL.IService
{
    public interface IArticleService
    {
        int SaveArticle(Article article);
        int DeleteArticle(string id);
        IEnumerable<Article> ListArticleByPaging(int size, int skip, string fields = "*");
        Article GetArticle(string id, string fields = "*");
        IEnumerable<Article> PagerArticleList(int size, int skip, string id, string title, string catalog, out int total, string fields = "*");
    }
}