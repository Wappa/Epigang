from django.urls import path
from Articles import views
from .views import ArticleListView, ArticleDetailView

app_name = "Articles"
urlpatterns = [
    path('', ArticleListView.as_view()),
    path('article/<int:pk>/', ArticleDetailView.as_view(), name='article-detail'),
]
