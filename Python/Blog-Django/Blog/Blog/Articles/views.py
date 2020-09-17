from django.shortcuts import render, get_object_or_404
from django.http import HttpResponse
# Create your views here.
from django.views.generic import ListView, DetailView
from .models import Article

def index (request):
    return HttpResponse("Welcome to my blog")

class ArticleListView(ListView):
    model = Article
    queryset = Article.objects.reverse()
    templates_name = "Articles/article_list.html"


class ArticleDetailView(DetailView):
    model = Article
    queryset = Article.objects.all()
    template_name = "Articles/article_detail.html"